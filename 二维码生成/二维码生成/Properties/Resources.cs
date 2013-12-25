namespace 二维码生成.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), CompilerGenerated, DebuggerNonUserCode]
    internal class Resources
    {
        private static CultureInfo resourceCulture;
        private static System.Resources.ResourceManager resourceMan;

        internal Resources()
        {
        }

        internal static Bitmap aa
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("aa", resourceCulture);
            }
        }

        internal static Bitmap aaaa
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("aaaa", resourceCulture);
            }
        }

        internal static Bitmap button_cancel
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("button_cancel", resourceCulture);
            }
        }

        internal static Bitmap button_ok
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("button_ok", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static Bitmap my
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("my", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    System.Resources.ResourceManager manager = new System.Resources.ResourceManager("二维码生成.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        internal static Bitmap 蒙板
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("蒙板", resourceCulture);
            }
        }
    }
}

