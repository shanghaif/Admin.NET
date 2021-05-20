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
 * 
 * @export
 * @interface UpdateTenantInput
 */
export interface UpdateTenantInput {
    /**
     * 主键Id
     * @type {number}
     * @memberof UpdateTenantInput
     */
    id: any;
    /**
     * 公司名称
     * @type {string}
     * @memberof UpdateTenantInput
     */
    name: any;
    /**
     * 管理员名称
     * @type {string}
     * @memberof UpdateTenantInput
     */
    adminName: any;
    /**
     * 主机名称
     * @type {string}
     * @memberof UpdateTenantInput
     */
    host?: any | null;
    /**
     * 数据库连接
     * @type {string}
     * @memberof UpdateTenantInput
     */
    connection?: any | null;
    /**
     * 电子邮箱
     * @type {string}
     * @memberof UpdateTenantInput
     */
    email: any;
    /**
     * 电话号码
     * @type {string}
     * @memberof UpdateTenantInput
     */
    phone?: any | null;
    /**
     * 模式
     * @type {string}
     * @memberof UpdateTenantInput
     */
    schema?: any | null;
    /**
     * 备注
     * @type {string}
     * @memberof UpdateTenantInput
     */
    remark?: any | null;
    /**
     * 创建时间
     * @type {string}
     * @memberof UpdateTenantInput
     */
    createdTime?: any | null;
}
