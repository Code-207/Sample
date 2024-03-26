using System;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Iai.V20200303;
using TencentCloud.Iai.V20200303.Models;

namespace TencentCloudExamples
{
    class VerifyPerson
    {
        static void Main(string[] args)
        {
            #region Ces1
            try
            {
                // 实例化一个认证对象，入参需要传入腾讯云账户 SecretId 和 SecretKey，此处还需注意密钥对的保密
                // 代码泄露可能会导致 SecretId 和 SecretKey 泄露，并威胁账号下所有资源的安全性。以下代码示例仅供参考，建议采用更安全的方式来使用密钥，请参见：https://cloud.tencent.com/document/product/1278/85305
                // 密钥可前往官网控制台 https://console.cloud.tencent.com/cam/capi 进行获取
                Credential cred = new Credential {
                    SecretId = "AKIDtsqojZL0nKylhu7weCanao1FWtEd7iJ2",
                    SecretKey = "rfWTWYWM6oOn26yhFdu2zm3FF4iEanqj"
                };
                // 实例化一个client选项，可选的，没有特殊需求可以跳过
                ClientProfile clientProfile = new ClientProfile();
                // 实例化一个http选项，可选的，没有特殊需求可以跳过
                HttpProfile httpProfile = new HttpProfile();
                httpProfile.Endpoint = ("iai.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                // 实例化要请求产品的client对象,clientProfile是可选的
                IaiClient client = new IaiClient(cred, "", clientProfile);
                // 实例化一个请求对象,每个接口都会对应一个request对象
                VerifyPersonRequest req = new VerifyPersonRequest();
                
                // 返回的resp是一个VerifyPersonResponse的实例，与请求对象对应
                VerifyPersonResponse resp = client.VerifyPersonSync(req);
                // 输出json格式的字符串回包
                Console.WriteLine(AbstractModel.ToJsonString(resp));
            }
            catch (Exception e)
            {
                Console.WriteLine("2".ToString());
                Console.WriteLine(e.ToString());
            }
            Console.Read();
            #endregion
        }
    }
}
            