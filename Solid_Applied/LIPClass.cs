using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Applied
{
    public class LSPClass
    {

        public LSPClass()
        {

            EMailOperations eMail = new SendGridAPIOperation();
            eMail.GetStacks();

            eMail = new SMTPOperation();
            eMail.GetStacks();

        } 

public abstract class EMailOperations
{
    public virtual void GetStacks()
    {
        throw new NotImplementedException();
    }

}
public class SendGridAPIOperation : EMailOperations
{
    public override void GetStacks()
    {
        throw new NotImplementedException();
    }
}
public class SMTPOperation : EMailOperations
{
    public override void GetStacks()
    {
        throw new NotImplementedException();
    }
}
    }
}
