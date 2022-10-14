using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WhatsApp.Desktop.Extensions
{
    public static class StoryboardExtensions
    {
        #region Slide from/to right

        /// <summary>
        /// Adds a slide effect on an element from right into the viewport
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="offset"></param>
        /// <param name="duration"></param>
        public static void AddSlideFromRight(this Storyboard storyboard, double offset, double decelerationRatio = 0.9D, float duration = 0.3f)
        {
            var animation = new ThicknessAnimation
            {
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = decelerationRatio
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a slide effect to an element out of the viewport to the right
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="offset"></param>
        /// <param name="duration"></param>
        public static void AddSlideToRight(this Storyboard storyboard, double offset, double decelerationRatio = 0.9D, float duration = 0.3f)
        {
            var animation = new ThicknessAnimation
            {
                From = new Thickness(0),
                To = new Thickness(offset, 0, -offset, 0),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = decelerationRatio
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        #endregion

        #region Slide from/to left

        /// <summary>
        /// Adds a slide animation effect to an element which slides the element into the
        /// viewport from the left.
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="offset"></param>
        /// <param name="decelerationRatio"></param>
        /// <param name="duration"></param>
        public static void AddSlideFromLeft(this Storyboard storyboard, double offset, double decelerationRatio = 0.9D, float duration = 0.3f)
        {
            var animation = new ThicknessAnimation
            {
                From = new Thickness(-offset, 0, offset, 0),
                To = new Thickness(0),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = decelerationRatio
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a slide animation effect to move an element out of the viewport to the left
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="offset"></param>
        /// <param name="decelerationRatio"></param>
        /// <param name="duration"></param>
        public static void AddSlideToLeft(this Storyboard storyboard, double offset, double decelerationRatio = 0.9D, float duration = 0.3f, bool keepMargin = true)
        {
            var animation = new ThicknessAnimation
            {
                From = new Thickness(0),
                To = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = decelerationRatio
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        #endregion

        #region Slide from/to bottom

        /// <summary>
        /// Adds a slide animation effect to an element which slides the element into the
        /// viewport from the bottom.
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="offset"></param>
        /// <param name="decelerationRatio"></param>
        /// <param name="duration"></param>
        public static void AddSlideFromBottom(this Storyboard storyboard, double offset, double decelerationRatio = 0.9D, float duration = 0.3f)
        {
            var animation = new ThicknessAnimation
            {
                From = new Thickness(0, offset, 0, -offset),
                To = new Thickness(0),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = decelerationRatio
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a slide animation effect to move an element out of the viewport to the bottom
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="offset"></param>
        /// <param name="decelerationRatio"></param>
        /// <param name="duration"></param>
        public static void AddSlideToBottom(this Storyboard storyboard, double offset, double decelerationRatio = 0.9D, float duration = 0.3f)
        {
            var animation = new ThicknessAnimation
            {
                From = new Thickness(0),
                To = new Thickness(0, offset, 0, -offset),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = decelerationRatio
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        #endregion

        #region Fade In/out effect

        /// <summary>
        /// Fades an element into the screen from an invisible state
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="duration"></param>
        public static void FadeIn(this Storyboard storyboard, float duration = 0.3f)
        {
            var animation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(duration))
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Fades an element out of the screen
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="duration"></param>
        public static void FadeOut(this Storyboard storyboard, float duration = 0.3f)
        {
            var animation = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(duration))
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);
        }

        #endregion
    }
}
