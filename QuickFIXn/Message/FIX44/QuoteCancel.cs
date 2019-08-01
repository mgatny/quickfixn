// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class QuoteCancel : Message
        {
            public const string MsgType = "Z";

            public QuoteCancel() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("Z"));
            }

            public QuoteCancel(
                    QuickFix.Fields.QuoteReqID aQuoteReqID,
                    QuickFix.Fields.QuoteID aQuoteID,
                    QuickFix.Fields.QuoteCancelType aQuoteCancelType
                ) : this()
            {
                this.QuoteReqID = aQuoteReqID;
                this.QuoteID = aQuoteID;
                this.QuoteCancelType = aQuoteCancelType;
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
            public QuickFix.Fields.QuoteID QuoteID
            { 
                get 
                {
                    QuickFix.Fields.QuoteID val = new QuickFix.Fields.QuoteID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteID val) 
            { 
                this.QuoteID = val;
            }
            
            public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteID val) 
            { 
                return IsSetQuoteID();
            }
            
            public bool IsSetQuoteID() 
            { 
                return IsSetField(Tags.QuoteID);
            }
            public QuickFix.Fields.QuoteCancelType QuoteCancelType
            { 
                get 
                {
                    QuickFix.Fields.QuoteCancelType val = new QuickFix.Fields.QuoteCancelType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteCancelType val) 
            { 
                this.QuoteCancelType = val;
            }
            
            public QuickFix.Fields.QuoteCancelType Get(QuickFix.Fields.QuoteCancelType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteCancelType val) 
            { 
                return IsSetQuoteCancelType();
            }
            
            public bool IsSetQuoteCancelType() 
            { 
                return IsSetField(Tags.QuoteCancelType);
            }
        }
    }
}
