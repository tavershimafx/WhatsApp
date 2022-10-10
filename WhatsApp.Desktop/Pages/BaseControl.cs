using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using WhatsApp.Core;
using WhatsApp.Desktop.Extensions;

namespace WhatsApp.Desktop
{
    public class BaseControl : UserControl
    {
        /// <summary>
        /// The animation pattern to perform for its entry motion
        /// </summary>
        public EntryAnimation EntryAnimation { get; set; } = EntryAnimation.SlideInFromRight;

        /// <summary>
        /// The animation effect to perform for its exit motion
        /// </summary>
        public ExitAnimation ExitAnimation { get; set; } = ExitAnimation.SlideOutToLeft;

        public BaseControl()
        {
            if (DesignerProperties.GetIsInDesignMode(this))
                return;

            this.Loaded += BasePage_Loaded;
        }

        private void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            AnimateIn();
        }

        public void AnimateIn()
        {
            switch (this.EntryAnimation)
            {
                case EntryAnimation.None:
                    break;
                case EntryAnimation.SlideInFromRight:
                    this.SlideAndFadeInFromRight(width: Application.Current.MainWindow.Width);
                    break;
                case EntryAnimation.SlideInFromLeft:
                    this.SlideAndFadeInFromLeft();
                    break;
                case EntryAnimation.SlideInFromBottom:
                    break;
                case EntryAnimation.SlideInFromTop:
                    break;
                default:
                    break;
            }
        }

        public void AnimateOut()
        {
            switch (this.ExitAnimation)
            {
                case ExitAnimation.None:
                    break;
                case ExitAnimation.SlideOutToRight:
                    break;
                case ExitAnimation.SlideOutToLeft:
                    this.SlideAndFadeOutToLeft(width: Application.Current.MainWindow.Width);
                    break;
                case ExitAnimation.SlideOutToBottom:
                    break;
                case ExitAnimation.SlideOutToTop:
                    break;
                default:
                    break;
            }
        }
    }

    /// <summary>
    /// A base type for all controls
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class BaseControl<TModel> : BaseControl where TModel : BaseViewModel, new()
    {

        #region Private members

        private TModel vModel;

        #endregion

        #region Public Properties

        public TModel ViewModel
        {
            get
            {
                return vModel;
            }
            set
            {
                vModel = value;
                DataContext = vModel;
            }
        }

        #endregion

        public BaseControl() : base()
        {
            ViewModel = new TModel();

        }
    }
}
