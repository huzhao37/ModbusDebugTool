// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Interface.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   请求接口  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    /// <summary>请求接口</summary>
    public interface IRequest
    {
        #region Public Properties

        /// <summary>子命令</summary>
        TtsFunction Function { get; set; }

        #endregion
    }

    /// <summary>响应接口</summary>
    public interface IResponse
    {
        #region Public Properties

        /// <summary>子命令</summary>
        TtsFunction Function { get; set; }

        #endregion
    }
}