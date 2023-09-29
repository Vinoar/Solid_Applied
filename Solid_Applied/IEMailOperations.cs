using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Applied
{
    public interface IEMailOperations
    {
        void SetupEMail();

        void SendEmail();

        void SendBulkEmail();

        void GetStacks();
    }

    public class SendGridAPIOperation : IEMailOperations
    {
        public void GetStacks()
        {
            throw new NotImplementedException();
        }

        public void SendBulkEmail()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }

        public void SetupEMail()
        {
            throw new NotImplementedException();
        }
    }

    public class SMTPOperation : IEMailOperations
    {
        public void GetStacks()
        {
            throw new NotImplementedException();
        }

        public void SendBulkEmail()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }

        public void SetupEMail()
        {
            throw new NotImplementedException();
        }
    }

    
}
