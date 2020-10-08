using System;
using System.Threading.Tasks;
using NetModular.Module.Quartz.Application.JobService.ViewModels;
using NetModular.Module.Quartz.Domain.Job.Models;
using NetModular.Module.Quartz.Domain.JobLog.Models;

namespace NetModular.Module.Quartz.Application.JobService
{
    /// <summary>
    /// 任务服务
    /// </summary>
    public interface IJobService
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Query(JobQueryModel model);

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Add(JobAddModel model);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResultModel> Edit(Guid id);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Update(JobUpdateModel model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        Task<IResultModel> Delete(Guid id);

        /// <summary>
        /// 暂停
        /// </summary>
        /// <returns></returns>
        Task<IResultModel> Pause(Guid id);

        /// <summary>
        /// 恢复
        /// </summary>
        /// <returns></returns>
        Task<IResultModel> Resume(Guid id);

        /// <summary>
        /// 停止
        /// </summary>
        /// <returns></returns>
        Task<IResultModel> Stop(Guid id);

        /// <summary>
        /// 查询日志
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Log(JobLogQueryModel model);

        /// <summary>
        /// 添加Http请求任务
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> AddHttpJob(JobHttpAddModel model);

        /// <summary>
        /// 编辑Http请求任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResultModel> EditHttpJob(Guid id);

        /// <summary>
        /// 更新Http请求任务
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> UpdateHttpJob(JobHttpUpdateModel model);

        /// <summary>
        /// HTTP任务详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResultModel> JobHttpDetails(Guid id);
    }
}
