﻿using ReactiveUI;
using System;

namespace XSOverlay_VRChat_Parser.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            playerJoinedChecked = PlayerJoinedChecked;
            playerLeftChecked = PlayerLeftChecked;
            worldChangedChecked = WorldChangedChecked;
            portalDroppedChecked = PortalDroppedChecked;
            shaderKeywordsChecked = ShaderKeywordsChecked;
            oscMessagingChecked = OscMessagingChecked;
            playerJoinedVolume = PlayerJoinedVolume;
            playerLeftVolume = PlayerLeftVolume;
            worldChangedVolume = WorldChangedVolume;
            portalDroppedVolume = PortalDroppedVolume;
            shaderKeywordsVolume = ShaderKeywordsVolume;
            playerJoinedTimeout = PlayerJoinedTimeout;
            playerLeftTimeout = PlayerLeftTimeout;
            portalDroppedTimeout = PortalDroppedTimeout;
            worldChangedTimeout = WorldChangedTimeout;
            shaderKeywordsTimeout = ShaderKeywordsTimeout;
        }

        private bool playerJoinedChecked;
        public bool PlayerJoinedChecked
        {
            get => UIMain.Configuration.DisplayPlayerJoined;
            set
            {
                if (playerJoinedChecked != value)
                {
                    UIMain.Configuration.DisplayPlayerJoined = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref playerJoinedChecked, value);
            }
        }

        private bool playerLeftChecked;
        public bool PlayerLeftChecked
        {
            get => UIMain.Configuration.DisplayPlayerLeft;
            set
            {
                if (playerLeftChecked != value)
                {
                    UIMain.Configuration.DisplayPlayerLeft = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref playerLeftChecked, value);
            }
        }

        private bool worldChangedChecked;
        public bool WorldChangedChecked
        {
            get => UIMain.Configuration.DisplayWorldChanged;
            set
            {
                if (worldChangedChecked != value)
                {
                    UIMain.Configuration.DisplayWorldChanged = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref worldChangedChecked, value);
            }
        }

        private bool portalDroppedChecked;
        public bool PortalDroppedChecked
        {
            get => UIMain.Configuration.DisplayPortalDropped;
            set
            {
                if (portalDroppedChecked != value)
                {
                    UIMain.Configuration.DisplayPortalDropped = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref portalDroppedChecked, value);
            }
        }

        private bool shaderKeywordsChecked;
        public bool ShaderKeywordsChecked
        {
            get => UIMain.Configuration.DisplayMaximumKeywordsExceeded;
            set
            {
                if (shaderKeywordsChecked != value)
                {
                    UIMain.Configuration.DisplayMaximumKeywordsExceeded = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref shaderKeywordsChecked, value);
            }
        }

        private float playerJoinedVolume;
        public float PlayerJoinedVolume
        {
            get => UIMain.Configuration.PlayerJoinedNotificationVolume;
            set
            {
                if (playerJoinedVolume != value)
                {
                    UIMain.Configuration.PlayerJoinedNotificationVolume = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref playerJoinedVolume, value);
            }
        }

        private float playerLeftVolume;
        public float PlayerLeftVolume
        {
            get => UIMain.Configuration.PlayerLeftNotificationVolume;
            set
            {
                if (playerLeftVolume != value)
                {
                    UIMain.Configuration.PlayerLeftNotificationVolume = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref playerLeftVolume, value);
            }
        }

        private float worldChangedVolume;
        public float WorldChangedVolume
        {
            get => UIMain.Configuration.WorldChangedNotificationVolume;
            set
            {
                if (worldChangedVolume != value)
                {
                    UIMain.Configuration.WorldChangedNotificationVolume = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref worldChangedVolume, value);
            }
        }

        private float portalDroppedVolume;
        public float PortalDroppedVolume
        {
            get => UIMain.Configuration.PortalDroppedNotificationVolume;
            set
            {
                if (portalDroppedVolume != value)
                {
                    UIMain.Configuration.PortalDroppedNotificationVolume = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref portalDroppedVolume, value);
            }
        }

        private float shaderKeywordsVolume;
        public float ShaderKeywordsVolume
        {
            get => UIMain.Configuration.MaximumKeywordsExceededNotificationVolume;
            set
            {
                if (shaderKeywordsVolume != value)
                {
                    UIMain.Configuration.MaximumKeywordsExceededNotificationVolume = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref shaderKeywordsVolume, value);
            }
        }

        private float playerJoinedTimeout;
        public float PlayerJoinedTimeout
        {
            get => UIMain.Configuration.PlayerJoinedNotificationTimeoutSeconds;
            set
            {
                if (playerJoinedTimeout != value)
                {
                    UIMain.Configuration.PlayerJoinedNotificationTimeoutSeconds = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref playerJoinedTimeout, value);
            }
        }

        private float playerLeftTimeout;
        public float PlayerLeftTimeout
        {
            get => UIMain.Configuration.PlayerLeftNotificationTimeoutSeconds;
            set
            {
                if (playerLeftTimeout != value)
                {
                    UIMain.Configuration.PlayerLeftNotificationTimeoutSeconds = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref playerLeftTimeout, value);
            }
        }

        private float portalDroppedTimeout;
        public float PortalDroppedTimeout
        {
            get => UIMain.Configuration.PortalDroppedTimeoutSeconds;
            set
            {
                if (portalDroppedTimeout != value)
                {
                    UIMain.Configuration.PortalDroppedTimeoutSeconds = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref portalDroppedTimeout, value);
            }
        }

        private float worldChangedTimeout;
        public float WorldChangedTimeout
        {
            get => UIMain.Configuration.WorldChangedNotificationTimeoutSeconds;
            set
            {
                if (worldChangedTimeout != value)
                {
                    UIMain.Configuration.WorldChangedNotificationTimeoutSeconds = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref worldChangedTimeout, value);
            }
        }

        private float shaderKeywordsTimeout;
        public float ShaderKeywordsTimeout
        {
            get => UIMain.Configuration.MaximumKeywordsExceededTimeoutSeconds;
            set
            {
                if (shaderKeywordsTimeout != value)
                {
                    UIMain.Configuration.MaximumKeywordsExceededTimeoutSeconds = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref shaderKeywordsTimeout, value);
            }
        }
        private string oscIpAddress;
        public string OscIpAddress
        {
            get => UIMain.Configuration.OscIpAddress;
            set
            {
                if (oscIpAddress != value)
                {
                    UIMain.Configuration.OscIpAddress = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref oscIpAddress, value);
            }
        }
        private string oscPortStr;
        public string OscPortStr
        {
            get => UIMain.Configuration.OscPort.ToString();
            set
            {
                if (oscPortStr != value)
                {
                    int newPort;
                    if (!int.TryParse(value.ToString(), out newPort))
                        return;
                    newPort = Math.Clamp(newPort, 0, ushort.MaxValue);
                    oscPortStr = newPort.ToString();
                    UIMain.Configuration.OscPort = newPort;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref oscPortStr, value);
            }
        }
        private bool oscMessagingChecked;
        public bool OscMessagingChecked
        {
            get => UIMain.Configuration.SendOscMessages;
            set
            {
                if (oscMessagingChecked != value)
                {
                    UIMain.Configuration.SendOscMessages = value;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref oscMessagingChecked, value);
            }
        }
        private string oscTimeoutMs;
        public string OscTimeoutMs
        {
            get => UIMain.Configuration.OscTimeoutMs.ToString();
            set
            {
                if (oscTimeoutMs != value)
                {
                    int newMs;
                    if (!int.TryParse(value.ToString(), out newMs))
                        return;
                    newMs = Math.Clamp(newMs, 25, int.MaxValue);
                    oscTimeoutMs = newMs.ToString();
                    UIMain.Configuration.OscTimeoutMs = newMs;
                    UIMain.SaveConfigurationDebounced();
                }
                this.RaiseAndSetIfChanged(ref oscTimeoutMs, value);
            }
        }
    }
}