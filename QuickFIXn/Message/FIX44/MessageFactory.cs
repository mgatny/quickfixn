// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX44
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX44.Logon.MsgType: return new QuickFix.FIX44.Logon();
                    case QuickFix.FIX44.Heartbeat.MsgType: return new QuickFix.FIX44.Heartbeat();
                    case QuickFix.FIX44.TestRequest.MsgType: return new QuickFix.FIX44.TestRequest();
                    case QuickFix.FIX44.ResendRequest.MsgType: return new QuickFix.FIX44.ResendRequest();
                    case QuickFix.FIX44.Reject.MsgType: return new QuickFix.FIX44.Reject();
                    case QuickFix.FIX44.SequenceReset.MsgType: return new QuickFix.FIX44.SequenceReset();
                    case QuickFix.FIX44.Logout.MsgType: return new QuickFix.FIX44.Logout();
                    case QuickFix.FIX44.QuoteRequest.MsgType: return new QuickFix.FIX44.QuoteRequest();
                    case QuickFix.FIX44.Quote.MsgType: return new QuickFix.FIX44.Quote();
                    case QuickFix.FIX44.QuoteRequestReject.MsgType: return new QuickFix.FIX44.QuoteRequestReject();
                    case QuickFix.FIX44.QuoteCancel.MsgType: return new QuickFix.FIX44.QuoteCancel();
                    case QuickFix.FIX44.DontKnowTrade.MsgType: return new QuickFix.FIX44.DontKnowTrade();
                    case QuickFix.FIX44.NewOrderSingle.MsgType: return new QuickFix.FIX44.NewOrderSingle();
                    case QuickFix.FIX44.ExecutionReport.MsgType: return new QuickFix.FIX44.ExecutionReport();
                    case QuickFix.FIX44.BusinessMessageReject.MsgType: return new QuickFix.FIX44.BusinessMessageReject();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX44.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX44.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup();
                    }
                }

                return null;
            }

        }
    }
}
