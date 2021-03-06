﻿using Hzdtf.Utility.Standard.Model.Return;
using Hzdtf.WorkFlow.Model.Standard;
using Hzdtf.WorkFlow.Service.Contract.Standard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hzdtf.WorkFlow.Service.Impl.Standard
{
    /// <summary>
    /// 送件流程路线服务
    /// @ 黄振东
    /// </summary>
    public partial class SendFlowRouteService : ISendFlowRouteServiceAsync
    {
        /// <summary>
        /// 异步根据流程关卡ID查询送件流程路线列表
        /// </summary>
        /// <param name="flowCensorshipId">流程关卡ID</param>
        /// <param name="connectionId">连接ID</param>
        /// <returns>任务</returns>
        public virtual async Task<ReturnInfo<IList<SendFlowRouteInfo>>> QueryByFlowCensorshipIdAsync(int flowCensorshipId, string connectionId = null)
        {
            return await Task.Run<ReturnInfo<IList<SendFlowRouteInfo>>>(() =>
            {
                return QueryByFlowCensorshipId(flowCensorshipId, connectionId);
            });
        }

        /// <summary>
        /// 异步根据流程关卡ID数组查询送件流程路线列表
        /// </summary>
        /// <param name="flowCensorshipIds">流程关卡ID</param>
        /// <param name="connectionId">连接ID</param>
        /// <returns>任务</returns>
        public virtual async Task<ReturnInfo<IList<SendFlowRouteInfo>>> QueryByFlowCensorshipIdsAsync(int[] flowCensorshipIds, string connectionId = null)
        {
            return await Task.Run<ReturnInfo<IList<SendFlowRouteInfo>>>(() =>
            {
                return QueryByFlowCensorshipIds(flowCensorshipIds, connectionId);
            });
        }
    }
}
