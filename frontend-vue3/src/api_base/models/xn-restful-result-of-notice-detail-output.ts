/* tslint:disable */
/* eslint-disable */
/**
 * Admin.NET通用权限管理平台
 * 前后端分离架构，开箱即用，紧随前沿技术。<br/><a href='https://gitee.com/zuohuaijun/Admin.NET/'>https://gitee.com/zuohuaijun/Admin.NET</a>
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
/**
 * RESTful风格---XIAONUO返回格式
 * @export
 * @interface XnRestfulResultOfNoticeDetailOutput
 */
export interface XnRestfulResultOfNoticeDetailOutput {
    /**
     * 执行成功
     * @type {boolean}
     * @memberof XnRestfulResultOfNoticeDetailOutput
     */
    success?: any;
    /**
     * 状态码
     * @type {number}
     * @memberof XnRestfulResultOfNoticeDetailOutput
     */
    code?: any | null;
    /**
     * 错误信息
     * @type {ModelObject}
     * @memberof XnRestfulResultOfNoticeDetailOutput
     */
    message?: any | null;
    /**
     * 
     * @type {NoticeDetailOutput}
     * @memberof XnRestfulResultOfNoticeDetailOutput
     */
    data?: any;
    /**
     * 附加数据
     * @type {ModelObject}
     * @memberof XnRestfulResultOfNoticeDetailOutput
     */
    extras?: any | null;
    /**
     * 时间戳
     * @type {number}
     * @memberof XnRestfulResultOfNoticeDetailOutput
     */
    timestamp?: any;
}
