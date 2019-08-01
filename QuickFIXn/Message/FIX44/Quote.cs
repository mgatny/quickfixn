// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class Quote : Message
        {
            public const string MsgType = "S";

            public Quote() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("S"));
            }

            public Quote(
                    QuickFix.Fields.QuoteReqID aQuoteReqID,
                    QuickFix.Fields.QuoteID aQuoteID,
                    QuickFix.Fields.QuoteType aQuoteType,
                    QuickFix.Fields.Product aProduct,
                    QuickFix.Fields.SecurityType aSecurityType,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Currency aCurrency,
                    QuickFix.Fields.SettlDate aSettlDate
                ) : this()
            {
                this.QuoteReqID = aQuoteReqID;
                this.QuoteID = aQuoteID;
                this.QuoteType = aQuoteType;
                this.Product = aProduct;
                this.SecurityType = aSecurityType;
                this.Symbol = aSymbol;
                this.Currency = aCurrency;
                this.SettlDate = aSettlDate;
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
            public QuickFix.Fields.QuoteType QuoteType
            { 
                get 
                {
                    QuickFix.Fields.QuoteType val = new QuickFix.Fields.QuoteType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteType val) 
            { 
                this.QuoteType = val;
            }
            
            public QuickFix.Fields.QuoteType Get(QuickFix.Fields.QuoteType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteType val) 
            { 
                return IsSetQuoteType();
            }
            
            public bool IsSetQuoteType() 
            { 
                return IsSetField(Tags.QuoteType);
            }
            public QuickFix.Fields.Product Product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Product val) 
            { 
                this.Product = val;
            }
            
            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(Tags.Product);
            }
            public QuickFix.Fields.SecurityType SecurityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                this.SecurityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.Symbol Symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            { 
                this.Symbol = val;
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Tags.Symbol);
            }
            public QuickFix.Fields.Currency Currency
            { 
                get 
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Currency val) 
            { 
                this.Currency = val;
            }
            
            public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Currency val) 
            { 
                return IsSetCurrency();
            }
            
            public bool IsSetCurrency() 
            { 
                return IsSetField(Tags.Currency);
            }
            public QuickFix.Fields.BidSpotRate BidSpotRate
            { 
                get 
                {
                    QuickFix.Fields.BidSpotRate val = new QuickFix.Fields.BidSpotRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidSpotRate val) 
            { 
                this.BidSpotRate = val;
            }
            
            public QuickFix.Fields.BidSpotRate Get(QuickFix.Fields.BidSpotRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidSpotRate val) 
            { 
                return IsSetBidSpotRate();
            }
            
            public bool IsSetBidSpotRate() 
            { 
                return IsSetField(Tags.BidSpotRate);
            }
            public QuickFix.Fields.OfferSpotRate OfferSpotRate
            { 
                get 
                {
                    QuickFix.Fields.OfferSpotRate val = new QuickFix.Fields.OfferSpotRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OfferSpotRate val) 
            { 
                this.OfferSpotRate = val;
            }
            
            public QuickFix.Fields.OfferSpotRate Get(QuickFix.Fields.OfferSpotRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OfferSpotRate val) 
            { 
                return IsSetOfferSpotRate();
            }
            
            public bool IsSetOfferSpotRate() 
            { 
                return IsSetField(Tags.OfferSpotRate);
            }
            public QuickFix.Fields.BidForwardPoints BidForwardPoints
            { 
                get 
                {
                    QuickFix.Fields.BidForwardPoints val = new QuickFix.Fields.BidForwardPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidForwardPoints val) 
            { 
                this.BidForwardPoints = val;
            }
            
            public QuickFix.Fields.BidForwardPoints Get(QuickFix.Fields.BidForwardPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidForwardPoints val) 
            { 
                return IsSetBidForwardPoints();
            }
            
            public bool IsSetBidForwardPoints() 
            { 
                return IsSetField(Tags.BidForwardPoints);
            }
            public QuickFix.Fields.OfferForwardPoints OfferForwardPoints
            { 
                get 
                {
                    QuickFix.Fields.OfferForwardPoints val = new QuickFix.Fields.OfferForwardPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OfferForwardPoints val) 
            { 
                this.OfferForwardPoints = val;
            }
            
            public QuickFix.Fields.OfferForwardPoints Get(QuickFix.Fields.OfferForwardPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OfferForwardPoints val) 
            { 
                return IsSetOfferForwardPoints();
            }
            
            public bool IsSetOfferForwardPoints() 
            { 
                return IsSetField(Tags.OfferForwardPoints);
            }
            public QuickFix.Fields.BidForwardPoints2 BidForwardPoints2
            { 
                get 
                {
                    QuickFix.Fields.BidForwardPoints2 val = new QuickFix.Fields.BidForwardPoints2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidForwardPoints2 val) 
            { 
                this.BidForwardPoints2 = val;
            }
            
            public QuickFix.Fields.BidForwardPoints2 Get(QuickFix.Fields.BidForwardPoints2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidForwardPoints2 val) 
            { 
                return IsSetBidForwardPoints2();
            }
            
            public bool IsSetBidForwardPoints2() 
            { 
                return IsSetField(Tags.BidForwardPoints2);
            }
            public QuickFix.Fields.OfferForwardPoints2 OfferForwardPoints2
            { 
                get 
                {
                    QuickFix.Fields.OfferForwardPoints2 val = new QuickFix.Fields.OfferForwardPoints2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OfferForwardPoints2 val) 
            { 
                this.OfferForwardPoints2 = val;
            }
            
            public QuickFix.Fields.OfferForwardPoints2 Get(QuickFix.Fields.OfferForwardPoints2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OfferForwardPoints2 val) 
            { 
                return IsSetOfferForwardPoints2();
            }
            
            public bool IsSetOfferForwardPoints2() 
            { 
                return IsSetField(Tags.OfferForwardPoints2);
            }
            public QuickFix.Fields.BidPx BidPx
            { 
                get 
                {
                    QuickFix.Fields.BidPx val = new QuickFix.Fields.BidPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidPx val) 
            { 
                this.BidPx = val;
            }
            
            public QuickFix.Fields.BidPx Get(QuickFix.Fields.BidPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidPx val) 
            { 
                return IsSetBidPx();
            }
            
            public bool IsSetBidPx() 
            { 
                return IsSetField(Tags.BidPx);
            }
            public QuickFix.Fields.OfferPx OfferPx
            { 
                get 
                {
                    QuickFix.Fields.OfferPx val = new QuickFix.Fields.OfferPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OfferPx val) 
            { 
                this.OfferPx = val;
            }
            
            public QuickFix.Fields.OfferPx Get(QuickFix.Fields.OfferPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OfferPx val) 
            { 
                return IsSetOfferPx();
            }
            
            public bool IsSetOfferPx() 
            { 
                return IsSetField(Tags.OfferPx);
            }
            public QuickFix.Fields.BidPx2 BidPx2
            { 
                get 
                {
                    QuickFix.Fields.BidPx2 val = new QuickFix.Fields.BidPx2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidPx2 val) 
            { 
                this.BidPx2 = val;
            }
            
            public QuickFix.Fields.BidPx2 Get(QuickFix.Fields.BidPx2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidPx2 val) 
            { 
                return IsSetBidPx2();
            }
            
            public bool IsSetBidPx2() 
            { 
                return IsSetField(Tags.BidPx2);
            }
            public QuickFix.Fields.OfferPx2 OfferPx2
            { 
                get 
                {
                    QuickFix.Fields.OfferPx2 val = new QuickFix.Fields.OfferPx2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OfferPx2 val) 
            { 
                this.OfferPx2 = val;
            }
            
            public QuickFix.Fields.OfferPx2 Get(QuickFix.Fields.OfferPx2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OfferPx2 val) 
            { 
                return IsSetOfferPx2();
            }
            
            public bool IsSetOfferPx2() 
            { 
                return IsSetField(Tags.OfferPx2);
            }
            public QuickFix.Fields.MidPx MidPx
            { 
                get 
                {
                    QuickFix.Fields.MidPx val = new QuickFix.Fields.MidPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MidPx val) 
            { 
                this.MidPx = val;
            }
            
            public QuickFix.Fields.MidPx Get(QuickFix.Fields.MidPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MidPx val) 
            { 
                return IsSetMidPx();
            }
            
            public bool IsSetMidPx() 
            { 
                return IsSetField(Tags.MidPx);
            }
            public QuickFix.Fields.MidPx2 MidPx2
            { 
                get 
                {
                    QuickFix.Fields.MidPx2 val = new QuickFix.Fields.MidPx2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MidPx2 val) 
            { 
                this.MidPx2 = val;
            }
            
            public QuickFix.Fields.MidPx2 Get(QuickFix.Fields.MidPx2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MidPx2 val) 
            { 
                return IsSetMidPx2();
            }
            
            public bool IsSetMidPx2() 
            { 
                return IsSetField(Tags.MidPx2);
            }
            public QuickFix.Fields.SettlDate SettlDate
            { 
                get 
                {
                    QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDate val) 
            { 
                this.SettlDate = val;
            }
            
            public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlDate val) 
            { 
                return IsSetSettlDate();
            }
            
            public bool IsSetSettlDate() 
            { 
                return IsSetField(Tags.SettlDate);
            }
            public QuickFix.Fields.SettlDate2 SettlDate2
            { 
                get 
                {
                    QuickFix.Fields.SettlDate2 val = new QuickFix.Fields.SettlDate2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDate2 val) 
            { 
                this.SettlDate2 = val;
            }
            
            public QuickFix.Fields.SettlDate2 Get(QuickFix.Fields.SettlDate2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlDate2 val) 
            { 
                return IsSetSettlDate2();
            }
            
            public bool IsSetSettlDate2() 
            { 
                return IsSetField(Tags.SettlDate2);
            }
            public QuickFix.Fields.TraderBidSpotRate TraderBidSpotRate
            { 
                get 
                {
                    QuickFix.Fields.TraderBidSpotRate val = new QuickFix.Fields.TraderBidSpotRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TraderBidSpotRate val) 
            { 
                this.TraderBidSpotRate = val;
            }
            
            public QuickFix.Fields.TraderBidSpotRate Get(QuickFix.Fields.TraderBidSpotRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TraderBidSpotRate val) 
            { 
                return IsSetTraderBidSpotRate();
            }
            
            public bool IsSetTraderBidSpotRate() 
            { 
                return IsSetField(Tags.TraderBidSpotRate);
            }
            public QuickFix.Fields.TraderOfferSpotRate TraderOfferSpotRate
            { 
                get 
                {
                    QuickFix.Fields.TraderOfferSpotRate val = new QuickFix.Fields.TraderOfferSpotRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TraderOfferSpotRate val) 
            { 
                this.TraderOfferSpotRate = val;
            }
            
            public QuickFix.Fields.TraderOfferSpotRate Get(QuickFix.Fields.TraderOfferSpotRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TraderOfferSpotRate val) 
            { 
                return IsSetTraderOfferSpotRate();
            }
            
            public bool IsSetTraderOfferSpotRate() 
            { 
                return IsSetField(Tags.TraderOfferSpotRate);
            }
            public QuickFix.Fields.TraderSpotMidPx TraderSpotMidPx
            { 
                get 
                {
                    QuickFix.Fields.TraderSpotMidPx val = new QuickFix.Fields.TraderSpotMidPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TraderSpotMidPx val) 
            { 
                this.TraderSpotMidPx = val;
            }
            
            public QuickFix.Fields.TraderSpotMidPx Get(QuickFix.Fields.TraderSpotMidPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TraderSpotMidPx val) 
            { 
                return IsSetTraderSpotMidPx();
            }
            
            public bool IsSetTraderSpotMidPx() 
            { 
                return IsSetField(Tags.TraderSpotMidPx);
            }
            public QuickFix.Fields.SalesMarkupNotional SalesMarkupNotional
            { 
                get 
                {
                    QuickFix.Fields.SalesMarkupNotional val = new QuickFix.Fields.SalesMarkupNotional();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SalesMarkupNotional val) 
            { 
                this.SalesMarkupNotional = val;
            }
            
            public QuickFix.Fields.SalesMarkupNotional Get(QuickFix.Fields.SalesMarkupNotional val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SalesMarkupNotional val) 
            { 
                return IsSetSalesMarkupNotional();
            }
            
            public bool IsSetSalesMarkupNotional() 
            { 
                return IsSetField(Tags.SalesMarkupNotional);
            }
            public QuickFix.Fields.SalesMarkupPercentage SalesMarkupPercentage
            { 
                get 
                {
                    QuickFix.Fields.SalesMarkupPercentage val = new QuickFix.Fields.SalesMarkupPercentage();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SalesMarkupPercentage val) 
            { 
                this.SalesMarkupPercentage = val;
            }
            
            public QuickFix.Fields.SalesMarkupPercentage Get(QuickFix.Fields.SalesMarkupPercentage val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SalesMarkupPercentage val) 
            { 
                return IsSetSalesMarkupPercentage();
            }
            
            public bool IsSetSalesMarkupPercentage() 
            { 
                return IsSetField(Tags.SalesMarkupPercentage);
            }
            public QuickFix.Fields.TraderForwardBidPoints TraderForwardBidPoints
            { 
                get 
                {
                    QuickFix.Fields.TraderForwardBidPoints val = new QuickFix.Fields.TraderForwardBidPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TraderForwardBidPoints val) 
            { 
                this.TraderForwardBidPoints = val;
            }
            
            public QuickFix.Fields.TraderForwardBidPoints Get(QuickFix.Fields.TraderForwardBidPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TraderForwardBidPoints val) 
            { 
                return IsSetTraderForwardBidPoints();
            }
            
            public bool IsSetTraderForwardBidPoints() 
            { 
                return IsSetField(Tags.TraderForwardBidPoints);
            }
            public QuickFix.Fields.TraderForwardOfferPoints TraderForwardOfferPoints
            { 
                get 
                {
                    QuickFix.Fields.TraderForwardOfferPoints val = new QuickFix.Fields.TraderForwardOfferPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TraderForwardOfferPoints val) 
            { 
                this.TraderForwardOfferPoints = val;
            }
            
            public QuickFix.Fields.TraderForwardOfferPoints Get(QuickFix.Fields.TraderForwardOfferPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TraderForwardOfferPoints val) 
            { 
                return IsSetTraderForwardOfferPoints();
            }
            
            public bool IsSetTraderForwardOfferPoints() 
            { 
                return IsSetField(Tags.TraderForwardOfferPoints);
            }
            public QuickFix.Fields.TraderForwardMidPoints TraderForwardMidPoints
            { 
                get 
                {
                    QuickFix.Fields.TraderForwardMidPoints val = new QuickFix.Fields.TraderForwardMidPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TraderForwardMidPoints val) 
            { 
                this.TraderForwardMidPoints = val;
            }
            
            public QuickFix.Fields.TraderForwardMidPoints Get(QuickFix.Fields.TraderForwardMidPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TraderForwardMidPoints val) 
            { 
                return IsSetTraderForwardMidPoints();
            }
            
            public bool IsSetTraderForwardMidPoints() 
            { 
                return IsSetField(Tags.TraderForwardMidPoints);
            }
            public QuickFix.Fields.TraderForwardBidPoints2 TraderForwardBidPoints2
            { 
                get 
                {
                    QuickFix.Fields.TraderForwardBidPoints2 val = new QuickFix.Fields.TraderForwardBidPoints2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TraderForwardBidPoints2 val) 
            { 
                this.TraderForwardBidPoints2 = val;
            }
            
            public QuickFix.Fields.TraderForwardBidPoints2 Get(QuickFix.Fields.TraderForwardBidPoints2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TraderForwardBidPoints2 val) 
            { 
                return IsSetTraderForwardBidPoints2();
            }
            
            public bool IsSetTraderForwardBidPoints2() 
            { 
                return IsSetField(Tags.TraderForwardBidPoints2);
            }
            public QuickFix.Fields.TraderForwardOfferPoints2 TraderForwardOfferPoints2
            { 
                get 
                {
                    QuickFix.Fields.TraderForwardOfferPoints2 val = new QuickFix.Fields.TraderForwardOfferPoints2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TraderForwardOfferPoints2 val) 
            { 
                this.TraderForwardOfferPoints2 = val;
            }
            
            public QuickFix.Fields.TraderForwardOfferPoints2 Get(QuickFix.Fields.TraderForwardOfferPoints2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TraderForwardOfferPoints2 val) 
            { 
                return IsSetTraderForwardOfferPoints2();
            }
            
            public bool IsSetTraderForwardOfferPoints2() 
            { 
                return IsSetField(Tags.TraderForwardOfferPoints2);
            }
        }
    }
}
