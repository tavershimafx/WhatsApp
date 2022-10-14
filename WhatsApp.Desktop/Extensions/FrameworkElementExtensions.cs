using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace WhatsApp.Desktop.Extensions
{
    /// <summary>
    /// Animations for any <see cref="FrameworkElement"/>
    /// </summary>
    public static class FrameworkElementExtensions
    {
        /// <summary>
        /// Adds a slide and fade effect to an element into the screen
        /// </summary>
        /// <param name="element"></param>
        public static void SlideAndFadeInFromRight(this FrameworkElement element, float seconds = 0.9f, double width = 0)
        {
            Storyboard storyboard = new ();

            // Add a slide effect
            storyboard.AddSlideFromRight(width == 0 ? element.ActualWidth : width, duration: seconds);

            // add a fade effect
            storyboard.FadeIn();

            storyboard.Begin(element);
            element.Visibility = Visibility.Visible;

            Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Fades an element out into a visibility obvillion
        /// </summary>
        /// <param name="element"></param>
        public static void SlideAndFadeOutToLeft(this FrameworkElement element, float seconds = 0.9f, double width = 0)
        {
            Storyboard storyboard = new();

            // Add a slide out effect
            storyboard.AddSlideToLeft(width == 0? element.ActualWidth : width, duration: seconds);

            // add a fade effect
            storyboard.FadeIn();

            storyboard.Begin(element);
            element.Visibility = Visibility.Visible;
             
            Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Adds a slide and fade in effect from the left into the screen to the <paramref name="element"/>
        /// </summary>
        /// <param name="element"></param>
        /// <param name="seconds"></param>
        /// <param name="width"></param>
        public static void SlideAndFadeInFromLeft(this FrameworkElement element, float seconds = 0.9f, double width = 0)
        {
            Storyboard storyboard = new();

            // Add a slide in effect
            storyboard.AddSlideFromLeft(width == 0 ? element.ActualWidth : width, duration: seconds);

            // add a fade effect
            storyboard.FadeIn();

            storyboard.Begin(element);
            element.Visibility = Visibility.Visible;

            Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Adds a slide and fade effect on an <paramref name="element"/> into the screen from
        /// the bottom
        /// </summary>
        /// <param name="element"></param>
        /// <param name="seconds"></param>
        /// <param name="height"></param>
        public static void SlideAndFadeInFromBottom(this FrameworkElement element, float seconds = 0.9f, double height = 0)
        {
            Storyboard storyboard = new();

            // Add a slide in effect
            storyboard.AddSlideFromBottom(height == 0 ? element.ActualHeight : height, duration: seconds);

            // add a fade effect
            storyboard.FadeIn();

            storyboard.Begin(element);
            element.Visibility = Visibility.Visible;

            Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Adds a slide and fade effect on the <paramref name="element"/> which transits it out
        /// of the screen using the bottom as the exit path.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="seconds"></param>
        /// <param name="height"></param>
        public static void SlideAndFadeOutToBottom(this FrameworkElement element, float seconds = 0.9f, double height = 0)
        {
            Storyboard storyboard = new();

            // Add a slide in effect
            storyboard.AddSlideToBottom(height == 0 ? element.ActualHeight : height, duration: seconds);

            // add a fade effect
            storyboard.FadeIn();

            storyboard.Begin(element);
            element.Visibility = Visibility.Visible;

            Task.Delay((int)(seconds * 1000));
        }
    }
}
