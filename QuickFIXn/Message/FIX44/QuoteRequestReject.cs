// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class QuoteRequestReject : Message
        {
            public const string MsgType = "AG";

            public QuoteRequestReject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("AG"));
            }

            public QuoteRequestReject(
                    QuickFix.Fields.QuoteReqID aQuoteReqID,
                    QuickFix.Fields.QuoteRequestRejectReason aQuoteRequestRejectReason
                ) : this()
            {
                this.QuoteReqID = aQuoteReqID;
                this.QuoteRequestRejectReason = aQuoteRequestRejectReason;
            }

            public QuickFix.Fields.QuoteReqID QuoteReqID
            { 
                get 
                {
                    QuickFix.Fields.QuoteReqID val = new QuickFix.Fields.QuoteReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteReqID val) 
            { 
                this.QuoteReqID = val;
            }
            
            public QuickFix.Fields.QuoteReqID Get(QuickFix.Fields.QuoteReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteReqID val) 
            { 
                return IsSetQuoteReqID();
            }
            
            public bool IsSetQuoteReqID() 
            { 
                return IsSetField(Tags.QuoteReqID);
            }
            public QuickFix.Fields.QuoteRequestRejectReason QuoteRequestRejectReason
            { 
                get 
                {
                    QuickFix.Fields.QuoteRequestRejectReason val = new QuickFix.Fields.QuoteRequestRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteRequestRejectReason val) 
            { 
                this.QuoteRequestRejectReason = val;
            }
            
            public QuickFix.Fields.QuoteRequestRejectReason Get(QuickFix.Fields.QuoteRequestRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteRequestRejectReason val) 
            { 
                return IsSetQuoteRequestRejectReason();
            }
            
            public bool IsSetQuoteRequestRejectReason() 
            { 
                return IsSetField(Tags.QuoteRequestRejectReason);
            }
            public QuickFix.Fields.Text Text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Text val) 
            { 
                this.Text = val;
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Tags.Text);
            }
        }
    }
}
