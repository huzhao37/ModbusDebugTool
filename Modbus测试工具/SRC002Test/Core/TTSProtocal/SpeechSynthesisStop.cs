// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpeechSynthesisStop.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The speech synthesis stop  create version by chenqi.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ModbusDebugTool.Core.TTSProtocal
{
    using System;

    using NewLife.Model;

    /// <summary>
    /// The speech synthesis stop.
    /// </summary>
    public class SpeechSynthesisStop : TtsEntity, IRequest
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="SpeechSynthesisStop"/> class.
        /// </summary>
        static SpeechSynthesisStop()
        {
            ObjectContainer.Current.Register<IRequest, SpeechSynthesisStop>(TtsFunction.SpeechSynthesisStop);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechSynthesisStop"/> class.
        /// </summary>
        public SpeechSynthesisStop()
        {
            this.Function = TtsFunction.SpeechSynthesisStop;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The calculate extend data.
        /// </summary>
        public override void CalculateExtendData()
        {
            // base.CalculateExtendData();
            this.ExtendData.Clear();
            this.ExtendData.Add((Byte)this.Function);
        }

        /// <summary>
        /// The set args.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public override void SetArgs(object[] args)
        {
            base.SetArgs(args);
        }

        #endregion
    }
}