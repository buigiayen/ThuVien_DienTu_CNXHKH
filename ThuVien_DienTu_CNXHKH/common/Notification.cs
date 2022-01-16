using DevExpress.Utils.Base;
using DevExpress.XtraBars.ToastNotifications;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien_DienTu_CNXHKH.common
{
    public class Notification : FunctionPattent.BaseFunction<Notification>
    {
        public async Task ShowInformationToast(string text)
        {
            ToastNotificationsManager toastNotificationsManager = new ToastNotificationsManager();
            IToastNotificationProperties toastNotificationProperties = new Toast();
            toastNotificationProperties.AttributionText = text;
            toastNotificationProperties.Sound = ToastNotificationSound.Mail;
            toastNotificationProperties.Header = "Thư viện điện tử";
            toastNotificationProperties.Image = (Image)Properties.Resources.Toast;
            toastNotificationsManager.ShowNotification(toastNotificationProperties);

        }
        public async Task ShowWarningToast(string text)
        {
            ToastNotificationsManager toastNotificationsManager = new ToastNotificationsManager();
            IToastNotificationProperties toastNotificationProperties = new Toast();
            toastNotificationProperties.AttributionText = text;
            toastNotificationProperties.Sound = ToastNotificationSound.Reminder;
            toastNotificationProperties.Header = "Thư viện điện tử";
            toastNotificationsManager.ShowNotification(toastNotificationProperties);
        }


        public class Toast : IToastNotificationProperties
        {
            public ToastNotificationTemplate Template { get; set; } = ToastNotificationTemplate.Text01;
            public ToastNotificationDuration Duration { get; set; } = ToastNotificationDuration.Default;
            public ToastNotificationSound Sound { get; set; } = ToastNotificationSound.IM;
            public object ID { get; set; } = "ID";
            public Image Image { get; set; }
            public string ImagePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public Image AppLogoImage { get; set; }
            public string AppLogoImagePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public AppLogoCrop AppLogoImageCrop { get; set; } = AppLogoCrop.None;
            public Image HeroImage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string HeroImagePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Header { get; set; }
            public string Body { get; set; } = "Thông báo";
            public string Body2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string AttributionText { get; set; }
            public DateTimeOffset? DisplayTimestamp { get; set; }

            public bool HasImage => false;

            public bool HasImagePath => false;

            public bool HasAppLogoImage => false;

            public bool HasAppLogoImagePath => false;

            public bool HasHeroImage => false;

            public bool HasHeroImagePath => false;

            public bool IsDisposing => false;

            public bool IsUpdateLocked => false;

            public event EventHandler Changed;
            public event EventHandler Disposed;

            public void Assign(IPropertiesProvider source)
            {
                throw new NotImplementedException();
            }

            public void BeginUpdate()
            {
                throw new NotImplementedException();
            }

            public void CancelUpdate()
            {
                throw new NotImplementedException();
            }

            public IBaseProperties Clone()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public void EndUpdate()
            {
                throw new NotImplementedException();
            }

            public T GetContent<T>(string property)
            {
                throw new NotImplementedException();
            }

            public T GetDefaultValue<T>(string property)
            {
                throw new NotImplementedException();
            }

            public IDictionaryEnumerator GetProperties()
            {
                throw new NotImplementedException();
            }

            public T GetValue<T>(string property)
            {
                throw new NotImplementedException();
            }

            public bool IsContentProperty(string property)
            {
                throw new NotImplementedException();
            }

            public bool IsDefault(string property)
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public bool ShouldSerialize()
            {
                throw new NotImplementedException();
            }
        }
    }
}
