﻿using com.vtcsecure.ace.windows.Enums;
using com.vtcsecure.ace.windows.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VATRP.Core.Model;

namespace com.vtcsecure.ace.windows.CustomControls.UnifiedSettings
{
    /// <summary>
    /// Interaction logic for UnifiedSettingsGeneralCtrl.xaml
    /// </summary>
    public partial class UnifiedSettingsGeneralCtrl : BaseUnifiedSettingsPanel
    {
        public CallViewCtrl CallControl;

        public UnifiedSettingsGeneralCtrl()
        {
            InitializeComponent();
            Title = "General";
            this.Loaded += UnifiedSettingsGeneralCtrl_Loaded;
        }

        // ToDo - VATRP98populate when we know where the settings are stored
        private void UnifiedSettingsGeneralCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            Initialize();
        }

        public override void Initialize()
        {

            //************************************************************************************************************************************
            // Initilize of More==>Settings==>General
            //************************************************************************************************************************************
            base.Initialize();
            // intialize start on boot:
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string applicationName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            if (registryKey.GetValue(applicationName) == null)
            {
                // the application is not set to run at startup
                StartAtBootCheckbox.IsChecked = false;
            }
            else
            {
                // the application is set to run at startup
                StartAtBootCheckbox.IsChecked = true;
            }

            bool autoAnswerEnabled = ServiceManager.Instance.ConfigurationService.Get(Configuration.ConfSection.GENERAL,
                    Configuration.ConfEntry.AUTO_ANSWER, false);
            AutoAnswerAfterNotificationCheckBox.IsChecked = autoAnswerEnabled;

            if (App.CurrentAccount == null)
                return;
            string transport = App.CurrentAccount.Transport;
            if (!string.IsNullOrEmpty(transport) && transport.Equals("TCP"))  // unencrypted, tls = encrypted
            {
                SipEncryptionCheckbox.IsChecked = false;
            }
            else
            {
                SipEncryptionCheckbox.IsChecked = true;
            }
            MuteMicrophoneCheckBox.IsChecked = App.CurrentAccount.MuteMicrophone;
            MuteSpeakerCheckBox.IsChecked = App.CurrentAccount.MuteSpeaker;
            EchoCancelCheckBox.IsChecked = App.CurrentAccount.EchoCancel;
            ShowSelfViewCheckBox.IsChecked = App.CurrentAccount.ShowSelfView;

        }

        public override void ShowAdvancedOptions(bool show)
        {
            base.ShowAdvancedOptions(show);
            System.Windows.Visibility visibleSetting = System.Windows.Visibility.Collapsed;
            if (show)
            {
                visibleSetting = System.Windows.Visibility.Visible;
            }
//            VideoMailUriLabel.Visibility = visibleSetting;
//            VideoMailUriTextBox.Visibility = visibleSetting;
        }
        public override void ShowSuperOptions(bool show)
        {
            base.ShowSuperOptions(show);

            // 1170-ready: this is specified as android only. is implemented for windows.
            StartAtBootLabel.Visibility = BaseUnifiedSettingsPanel.VisibilityForSuperSettingsAsPreview;
            StartAtBootCheckbox.Visibility = BaseUnifiedSettingsPanel.VisibilityForSuperSettingsAsPreview;

            // this is specified as android only.
            WifiOnlyLabel.Visibility = System.Windows.Visibility.Collapsed;
            WifiOnlyCheckBox.Visibility = System.Windows.Visibility.Collapsed;

            // this is specified for android and ios. Implemented.
            AutoAnswerAfterNotificationCheckBox.Visibility = BaseUnifiedSettingsPanel.VisibilityForSuperSettingsAsPreview;
            AutoAnswerAfterNotificationLabel.Visibility = BaseUnifiedSettingsPanel.VisibilityForSuperSettingsAsPreview;
                
        }

        //
        private void OnStartOnBoot(object sender, RoutedEventArgs e)
        {

            //************************************************************************************************************************************
            // Start a Boot setting changed from More==>Settings==>General
            //************************************************************************************************************************************
            Console.WriteLine("Start at Boot Clicked");

            string applicationName = "ACE";

            bool enabled = this.StartAtBootCheckbox.IsChecked ?? false;
            if (enabled)
            {
                string startupPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    key.SetValue(applicationName, "\"" + startupPath + "\"");
                }
            }
            else
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    key.DeleteValue(applicationName, false);
                }
            }
        }
        private void OnWifiOnly(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Auto Answer Call Clicked");
            bool enabled = WifiOnlyCheckBox.IsChecked ?? false;
            // placeholder - not yet indicated for windows
        }
        private void OnSipEncryption(object sender, RoutedEventArgs e)
        {

            //************************************************************************************************************************************
            //SIP Encryption setting changed from More==>Settings==>General
            //************************************************************************************************************************************
            Console.WriteLine("SIP Encryption Clicked");
            if (App.CurrentAccount == null)
                return;
            bool enabled = SipEncryptionCheckbox.IsChecked ?? false;
            bool changed = false;
            if (!enabled)  // unencrypted = "TCP", tls = encrypted
            {
                if (!App.CurrentAccount.Transport.Equals("TCP"))
                {
                    App.CurrentAccount.Transport = "TCP";
                    App.CurrentAccount.ProxyPort = 25060;
                    changed = true;
                }
            }
            else
            {
                if (!App.CurrentAccount.Transport.Equals("TLS"))
                {
                    App.CurrentAccount.Transport = "TLS";
                    App.CurrentAccount.ProxyPort = 25061;
                    changed = true;
                }
            }
            if (changed)
            {
                OnAccountChangeRequested(Enums.ACEMenuSettingsUpdateType.RegistrationChanged);
            }
        }

        private void OnAutoAnswerAfterNotification(object sender, RoutedEventArgs e)
        {
            //************************************************************************************************************************************
            // Auto Answer setting changed from More==>Settings==>General
            //************************************************************************************************************************************
            Console.WriteLine("Auto Answer After Notification Clicked");
            bool enabled = AutoAnswerAfterNotificationCheckBox.IsChecked ?? false;
            ServiceManager.Instance.ConfigurationService.Set(Configuration.ConfSection.GENERAL,
                 Configuration.ConfEntry.AUTO_ANSWER, enabled);
            ServiceManager.Instance.ConfigurationService.SaveConfig();
        }

        public override void UpdateForMenuSettingChange(ACEMenuSettingsUpdateType menuSetting)
        {
            if (App.CurrentAccount == null)
                return;

            switch (menuSetting)
            {
                case ACEMenuSettingsUpdateType.MuteMicrophoneMenu: MuteMicrophoneCheckBox.IsChecked = App.CurrentAccount.MuteMicrophone;
                    break;
                case ACEMenuSettingsUpdateType.MuteSpeakerMenu: MuteSpeakerCheckBox.IsChecked = App.CurrentAccount.MuteSpeaker;
                    break;
                case ACEMenuSettingsUpdateType.ShowSelfViewMenu: ShowSelfViewCheckBox.IsChecked = App.CurrentAccount.ShowSelfView;
                    break;
                default:
                    break;
            }
        }

        private void OnMuteMicrophone(object sender, RoutedEventArgs e)
        {

            //************************************************************************************************************************************
            // Mute Microphone setting changed from More==>Settings==>General
            //************************************************************************************************************************************
            if (App.CurrentAccount == null)
                return;
            Console.WriteLine("Mute Microphone Clicked");
            bool enabled = MuteMicrophoneCheckBox.IsChecked ?? false;
            if (enabled != App.CurrentAccount.MuteMicrophone)
            {
                App.CurrentAccount.MuteMicrophone = enabled;
                ServiceManager.Instance.ApplyMediaSettingsChanges();
                ServiceManager.Instance.SaveAccountSettings();

                if ((CallControl != null) && CallControl.IsLoaded)
                {
                    CallControl.UpdateMuteSettingsIfOpen();
                }
            }
        }
        private void OnMuteSpeaker(object sender, RoutedEventArgs e)
        {

            //************************************************************************************************************************************
            // Mute Speaker setting changed from More==>Settings==>General
            //************************************************************************************************************************************
            if (App.CurrentAccount == null)
                return;
            Console.WriteLine("Mute Speaker Clicked");
            bool enabled = MuteSpeakerCheckBox.IsChecked ?? false;
            if (enabled != App.CurrentAccount.MuteSpeaker)
            {
                App.CurrentAccount.MuteSpeaker = enabled;
                ServiceManager.Instance.ApplyMediaSettingsChanges();
                ServiceManager.Instance.SaveAccountSettings();

                if ((CallControl != null) && CallControl.IsLoaded)
                {
                    CallControl.UpdateMuteSettingsIfOpen();
                }
            }
        }
        private void OnEchoCancel(object sender, RoutedEventArgs e)
        {

            //************************************************************************************************************************************
            //Echo Cancel setting changed from More==>Settings==>General
            //************************************************************************************************************************************
            if (App.CurrentAccount == null)
                return;
            Console.WriteLine("Echo Cancel Call Clicked");
            bool enabled = this.EchoCancelCheckBox.IsChecked ?? false;
            if (enabled != App.CurrentAccount.EchoCancel)
            {
                App.CurrentAccount.EchoCancel = enabled;
                ServiceManager.Instance.ApplyMediaSettingsChanges();
                ServiceManager.Instance.SaveAccountSettings();
            }
        }
        private void OnShowSelfView(object sender, RoutedEventArgs e)
        {
            if (App.CurrentAccount == null)
                return;
            Console.WriteLine("Show Self View Clicked");
            if (App.CurrentAccount == null)
                return;
            bool enable = this.ShowSelfViewCheckBox.IsChecked ?? true;
            if (enable != App.CurrentAccount.ShowSelfView)
            {
                App.CurrentAccount.ShowSelfView = enable;
                ServiceManager.Instance.ApplyMediaSettingsChanges();
                ServiceManager.Instance.SaveAccountSettings();

                OnAccountChangeRequested(Enums.ACEMenuSettingsUpdateType.ShowSelfViewChanged);

            }
        }

        private void OnHighContrast(object sender, RoutedEventArgs e)
        {

            //************************************************************************************************************************************
            // High Contrast setting changed from More==>Settings==>General
            //************************************************************************************************************************************
            Console.WriteLine("Coming Soon: High Contrast Theme");
            if (HighContrastCheckBox.IsChecked ?? false)
            {
                System.Windows.MessageBox.Show("Coming soon", "ACE", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

    }
}
