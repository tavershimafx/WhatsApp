using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Core
{
    /// <summary>
    /// A view model for the progress bar
    /// </summary>
    public class ProgressBarViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The color of the progress bar indicator. The color in RGB without the #
        /// e.g ffffff
        /// </summary>
        public string ProgressColor { get; set; } = "00f800";

        /// <summary>
        /// A number from 0 to 100 indicating the current progress
        /// </summary>
        public double Percent { get; set; }
        #endregion
    }
}
