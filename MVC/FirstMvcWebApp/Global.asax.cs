using FirstMvcWebApp.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FirstMvcWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //����ÿ�����󶼵���
            //��WebӦ�ó���������������ִ��һ��
            //��Ӧ�ó����һ��������Ӧ�ó����򴴽��±�����
            //�ʺϴ���Ӧ�ó���Χ�ĳ�ʼ������

            AreaRegistration.RegisterAllAreas();//ע������
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//ע��ȫ�ֹ�����
            RouteConfig.RegisterRoutes(RouteTable.Routes);//ע��·��
            BundleConfig.RegisterBundles(BundleTable.Bundles);//ע����Դ����
            //GlobalConfiguration.Configure(WedApiConfig.Register);//ע��webapi��·��

            //GlobalFilters.Filters.Add(new AuthorizationFilter());//��ӹ�����
            GlobalFilters.Filters.Add(new ExceptionFilter());
            GlobalFilters.Filters.Add(new ActionFilter());
        }

        protected void Application_End(object sender, EventArgs e)
        {
            //����ÿ�����󶼵���
            //��Ӧ�ó���ر�ʱ���еĴ��룬�����һ��HttpApplication����֮��ִ��
            //����IIS�������ļ����£����̻��յ���Ӧ�ó���ת������һ��Ӧ�ó�����
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //����ÿ�����󶼵���
            //�Ự��ʼʱִ��
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //����ÿ�����󶼵���
            //�Ự���������ʱִ��
            //�����ڴ�������ʽ�����Session����Session��ʱ�Զ����ڣ��˷�������������
        }

        protected void Application_Init(object sender, EventArgs e)
        {
            //����ÿ�����󶼵���
            //��ÿһ��HttpApplicationʵ����ʼ����ʱ��ִ��
        }

        protected void Application_Disposed(object sender, EventArgs e)
        {
            //����ÿ�����󶼵���
            //��Ӧ�ó��򱻹ر�һ��ʱ��֮����.net����������׼��������ռ�õ��ڴ��ʱ�򱻵��á�
            //��ÿһ��HttpApplicationʵ��������֮ǰִ��
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //����ÿ�����󶼵���
            //����û�д���Ĵ��󶼻ᵼ�����������ִ��
        }


        /*********************************************************************/
        //ÿ�����󶼻ᰴ��˳��ִ�������¼�
        /*********************************************************************/

        void Application_BeginRequest(object sender, EventArgs e)
        {
            //ÿ������ʱ��һ���������¼������������һ��ִ��
        }

        void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            //��ִ����֤ǰ���������Ǵ�����֤�߼������
        }

        void Application_AuthorizeRequest(object sender, EventArgs e)
        {
            //����ȫģ���Ѿ���֤�˵�ǰ�û�����Ȩʱִ��
        }

        void Application_ResolveRequestCache(object sender, EventArgs e)
        {
            //��ASP.NET�����Ȩ�¼���ʹ����ģ��ӻ�����Ϊ�����ṩ����ʱ�������Ӷ������������ҳ�������WebService����ִ�С�
            //���������Ը�����վ�����ܣ�����¼������������ж������ǲ��Ǵ�Cache�еõ��ġ�
        }

        //------------------------------------------------------------------------
        //�����ʱ�����󽫱�ת�������ʳ������磺web���彫�����벢���ʵ����
        //------------------------------------------------------------------------

        void Application_AcquireRequestState(object sender, EventArgs e)
        {
            //��ȡ��Session������ض���Ϣ�����ڰ���Щ��Ϣ��䵽Session֮ǰִ��
        }

        void Application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            //�ں��ʵĴ������ִ������ǰ����
            //���ʱ��Session�Ϳ�������
        }

        //-------------------------------------------------
        //�����ʱ��ҳ����뽫�ᱻִ�У�ҳ�����ΪHTML
        //-------------------------------------------------

        void Application_PostRequestHandlerExecute(object sender, EventArgs e)
        {
            //�����������ɶ�����Ĵ���󱻵��á�
        }

        void Application_ReleaseRequestState(object sender, EventArgs e)
        {
            //�ͷ�����״̬
        }

        void Application_UpdateRequestCache(object sender, EventArgs e)
        {
            //Ϊ�˺��������󣬸�����Ӧ����ʱ������
        }

        void Application_EndRequest(object sender, EventArgs e)
        {
            //EndRequest������ӦRequestʱ���һ���������¼�
            //���ڶ����ͷŻ��ߴ��½�����ǰ���ʺ������ʱ���������
        }

        void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            //��ͻ��˷���Http��ͷ֮ǰ������
        }

        void Application_PreSendRequestContent(object sender, EventArgs e)
        {
            //��ͻ��˷���Http����֮ǰ������
        }
    }
}

