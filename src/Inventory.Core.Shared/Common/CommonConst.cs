using System.ComponentModel.DataAnnotations;

namespace HLS.Topup.Common
{
    public class CommonConst
    {
        public enum Channel : byte
        {
            WEB = 1,
            APP = 2,
            API = 3
        }

        public enum DepositStatus : byte
        {
            Pending = 0,
            Approved = 1,
            Canceled = 3,
            Deleted = 4,
            Error = 5,
            Processing = 6
        }

        public enum DepositType : byte
        {
            Deposit = 1,
            Increase = 2,
            Decrease = 3,
            SaleDeposit = 4,
            Cash = 5,
            BuyAirtime = 6,
            BuyGsim = 7
        }

        // public enum SaleManType : byte
        // {
        //     SaleStaff = 1,
        //     SaleLead = 2
        // }
        public enum SaleManStatus : byte
        {
            Active = 1,
            Lock = 2
        }

        public enum DebtLimitAmountStatus
        {
            Init = 0,
            Active = 1,
            Lock = 2
        }

        public enum ClearDebtType
        {
            CashOnHand = 1,
            CashInBank = 2
        }

        public enum ClearDebtStatus
        {
            Init = 0,
            Approval = 1,
            Cancel = 2
        }

        public enum AdjustmentType : byte
        {
            Increase = 1,
            Decrease = 2
        }

        public class IncrementCodeKey
        {
            public static readonly string DiscountCode = "Paygate_DiscountCodeWeb_Key";
            public static readonly string DepositCode = "Paygate_DepositCodeWeb_Key";
            public static readonly string TopupCode = "Paygate_TopupCodeWeb_Key";
        }

        public class SmsChannel
        {
            public static readonly string SimSender = "SimSender";
            public static readonly string BanchName = "BanchName";
            public static readonly string VNPAY = "VNPAY";
        }

        public class TelcoConst
        {
            public static readonly string Viettel = "VTE";
            public static readonly string Vinaphone = "VNA";
            public static readonly string Mobiphone = "VMS";
            public static readonly string Gmobile = "GMOBILE";
            public static readonly string VietNammobile = "VNM";
        }

        public class CategoryCodeConts
        {
            public static readonly string MOBILE_BILL = "MOBILE_BILL";
            public static readonly string EVN_BILL = "EVN_BILL";
        }

        public class PaymentInfoType
        {
            public static readonly string Success = "Success";
            public static readonly string Error = "Error";
        }

        public enum TransactionType : byte
        {
            Default = 0,
            Transfer = 1,
            Deposit = 2,
            Cashout = 3,
            Payment = 4,
            Revert = 5,
            MasterTopup = 6,
            MasterTopdown = 7,
            CorrectUp = 8,
            CorrectDown = 9,
            Block = 10,
            Unblock = 11,
            Topup = 12,
            Tkc = 13,
            PinCode = 14,
            CollectDiscount = 15,
            FeePriority = 16,
            CancelPayment = 17,
            CardCharges = 18,
            AdjustmentIncrease = 19,
            AdjustmentDecrease = 20,
            ClearDebt = 21,
            SaleDeposit = 22,
            Exchange = 23,
            Received = 25,
            PayBatch = 26,
            BuyAirtime = 29,
            Give = 30, //tặng gstar
            Voting = 31, //Voting
            Charging = 32
        }

        public enum TransStatus : byte
        {
            Init = 0,
            Done = 1,
            Cancel = 2,
            Error = 3,
            Reverted = 4,
            PartialRevert = 5,
            CorrectUp = 6,
            CorrectDown = 7
        }

        public enum CardPackageStatus : byte
        {
            Init = 0, //Khởi tạo
            Active = 1, //Hoạt động
            Lock = 2, //Khóa
            // Delete = 3, //Xóa
            // Undefined = 99, //Chưa xác định
        }

        public enum CardStatus : byte
        {
            Init = 0, //Khởi tạo
            Active = 1, //Hoạt động
            Exported = 2, //Đã xuất kho
            Delete = 3, //Xóa
            Cancelled = 4, //Hủy
            OnExchangeMode = 11, //Đang chuyển kho
            Undefined = 99, //Chưa xác định
        }

        public enum CardRequestStatus : byte
        {
            Init = 0,
            Success = 1,
            Canceled = 2,
            Failed = 3,
            TimeOver = 4,
            InProcessing = 6,
            ProcessTimeout = 7,
            InvalidCardValue = 8,
            Undefined = 99
        }

        public enum CardStockStatus : byte
        {
            Init = 0, //Khởi tạo
            Active = 1, //Hoạt động
            Lock = 2, //Khóa
            Delete = 3, //Xóa
            Undefined = 99, //Chưa xác định
        }

        public enum SimStatus : byte
        {
            Init = 0, //Khởi tạo
            Active = 1, //Hoạt động
            Lock = 2, //Khóa
            Delete = 3, //Xóa
            Undefined = 99 //Chưa xác định
        }

        public enum TopupStatus
        {
            Init = 0,
            Success = 1,
            Canceled = 2,
            Failed = 3,
            TimeOver = 4,
            InProcessing = 6,
            ProcessTimeout = 7,
            WaitForResult = 8,
            Paid = 9, //Đã thanh toán
            WaitForConfirm = 10, //Trạng thái gd chậm. chờ nạp bù và kết luận bằng tay
            UnFinished = 11, //Trạng thái nạp thiếu. chờ nạp bù và kết luận bằng tay
            ConfirmPaymentGw = 100, //Trạng thái nạp thiếu. chờ nạp bù và kết luận bằng tay
            Undefined = 99
        }

        public enum CardBatchType : byte
        {
            CardSale = 1,
            CardMapping = 2,
            MappingCanSale = 3
        }

        public enum SimAppType : byte
        {
            Modem = 1,
            MyViettel = 2,
            ViettelPay = 3,
            ViettelPayPro = 4
        }

        public enum CategoryStatus : byte
        {
            Init = 0,
            Active = 1,
            Lock = 2
        }

        public enum VerifyTransType : byte
        {
            LevelPassword = 1,
            Odp = 2,
            Otp = 3,
            Biometrics = 4,
            Fingerprint = 5,
            FaceId = 6,
            None = 0
        }

        public enum CategoryType : byte
        {
            Airtime = 1,
            PinCode = 2,
            Data = 3
        }

        public enum ProductStatus : byte
        {
            Init = 0,
            Active = 1,
            Lock = 2
        }

        public enum ProductType : byte
        {
            Airtime = 1,
            PinCode = 2,
            Data = 3,
            MemberShip = 4,
            FStar = 5
        }

        public enum ProviderStatus : byte
        {
            Init = 0, //Khởi tạo
            Active = 1, //Hoạt động
            Lock = 2 //Khóa
        }

        public enum ProviderType : byte
        {
            Telco = 1,
            PinCode = 2,
            Data = 3
        }

        public static class ServiceCodes
        {
            public static string TOPUP = "TOPUP";
            public static string TKC = "TKC";
            public static string PAYMENT_SMS_GAME = "PAYMENT_SMS_GAME";
            public static string PIN_CODE = "PIN_CODE";
            public static string PIN_DATA = "PIN_DATA";
            public static string PIN_GAME = "PIN_GAME";
            public static string TOPUP_DATA = "TOPUP_DATA";
            public static string PAY_BILL = "PAY_BILL";
            public static string QUERY_BILL = "QUERY_BILL";
            public static string TOPUP_BATCH = "TOPUP_BATCH";
            public static string TRANSFER_MONEY = "TRANSFER_MONEY";
            public static string RECEIVE_MONEY = "RECEIVE_MONEY";
            public static string RECEIVE_GIVEGSTAR = "RECEIVE_GIVEGSTAR";
            public static string GIVEGSTAR = "GIVEGSTAR";
            public static string DEPOSIT = "DEPOSIT";
            public static string REFUND = "REFUND";
            public static string PAYBATCH = "PAYBATCH";
            public static string PAYCOMMISSION = "PAYCOMMISSION";
            public static string FEE_PRIORITY = "FEE_PRIORITY";
            public static string CORRECT_UP = "CORRECT_UP";
            public static string CORRECT_DOWN = "CORRECT_DOWN";
            public static string TICKET = "TICKET";
        }

        public static class MessageType
        {
            public static string ServiceDisible = "ServiceDisible";
            public static string StaffOutTime = "StaffOutTime";
        }

        public enum DiscountStatus : byte
        {
            Pending = 0, //chờ duyệt
            Approved = 1, //đã duyệt
            Cancel = 3, //Đã hủy
            Applying = 2, //Đang áp dụng
            NotApply = 4, //Chưa ap dụng
            StopApply = 5, //Ngừng áp dụng
            Delete = 6 //Ngừng áp dụng
        }

        public enum DiscountType : byte
        {
            DiscountSystem = 1,
            DiscountNetwork = 2,
        }

        public enum FeeStatus : byte
        {
            Pending = 0, //chờ duyệt
            Approved = 1, //đã duyệt
            Cancel = 3, //Đã hủy
            Applying = 2, //Đang áp dụng
            NotApply = 4, //Chưa ap dụng
            StopApply = 5, //Ngừng áp dụng
            Delete = 6 //Ngừng áp dụng
        }

        public enum DiscountOrderCdnStatus : byte
        {
            Pending = 0, //chờ duyệt
            Approved = 1, //đã duyệt
            Cancel = 3, //Đã hủy
            Applying = 2, //Đang áp dụng
            NotApply = 4, //Chưa ap dụng
            StopApply = 5 //Ngừng áp dụng
        }

        public enum LevelDiscountStatus : byte
        {
            Default = 99,
            Init = 0,
            Payment = 1,
            Cancel = 3,
            Fail = 4
        }

        public enum SystemAccountType : byte
        {
            // System = 0, //hệ thống
            // Company = 1, //công ty
            // MasterAgent = 2, //tài khoản
            // Agent = 3, //tài khoản tuyến dưới
            // Staff = 4, //nhân viên
            // SaleLead = 5, //sale lead
            // Sale = 6, //sale
            // StaffApi = 7, //nv api
            // EndUser = 100, //EndUser
            // Default = 99

            System = 0, //hệ thống
            Company = 1, //công ty
            Agent = 2, //Đại lý
            Staff = 4, //nhân viên tài khoản
            ManagementLevel = 3, //Cấp quản lý
            Collaborator = 5, //cộng tác viên
            BusinessMember = 6, //thành viên kinh doanh

            //SaleLead = 5, //sale lead
            //Sale = 6, //sale
            AgentApi = 7, //tk kết nối api
            StaffApi = 8, //nv api
            StaffOrg = 9,

            //SaleLead = 8, //sale lead
            //Sale = 9, //sale
            EndUser = 100, //EndUser
            Default = 99
        }

        // public enum AgentType : byte
        // {
        //     Agent = 1, //tài khoản
        //     AgentApi = 2, //tài khoản bán hàng qua api
        //     AgentCampany = 3, //tài khoản có hệ thống riêng
        //     AgentGeneral = 4, //tài khoản tổng
        //     SubAgent = 5, //tài khoản con
        //     WholesaleAgent = 6, //Đại sỉ
        //     SubAgentApi = 7, //Đại cấp 1 api
        //     Default = 99
        // }

        public enum SaleType : byte
        {
            Normal = 0,
            Slow = 1,
            UnFinished = 2,
            Default = 99
        }

        public enum BankStatus : byte
        {
            Active = 1, //tài khoản
            Lock = 2
        }

        public enum OtpStatus
        {
            Init = 0,
            Success = 1,

            //Confirm = 2,
            Timeout = 3,
            Cancel = 4
        }

        public enum OtpType
        {
            Transfer = 1,
            PayBill = 2,
            Payment = 3,
            ResetPass = 4,
            ChangePassLevel2 = 5,
            Register = 6,
            Login = 7,
            ChangePaymentMethod = 8,
            ChangeUserName = 9,
            Other = 10,
            DigitalId = 11,
            OpenBankAccount = 12
        }

        public enum CountryStatus
        {
            Active = 1,
            Lock = 0
        }

        public enum CityStatus
        {
            Active = 1,
            Lock = 0
        }

        public enum DistrictStatus
        {
            Active = 1,
            Lock = 0
        }

        public enum WardStatus
        {
            Active = 1,
            Lock = 0
        }

        public enum IdType
        {
            IdentityCard = 1, //CMND
            CitizenIdentity = 2, //Căn cước
            Passport = 3, //Hộ chiếu,
            CitizenIdentityNew = 4, //Căn cước chíp
            NewId = 5, //CC
            Default = 99
        }

        public enum BotMessageType
        {
            Error = 1,
            Wraning = 2,
            Message = 3
        }

        public enum BotType
        {
            Dev = 1,
            Sale = 2,
            CardMapping = 3,
            Provider = 4,
            Transaction = 5,
            Stock = 6,
            Deposit = 7,
            Channel = 8
        }

        public enum PayBackStatus : byte
        {
            Init = 0,
            Approval = 2,
            Cancel = 3,
            Error = 4,
            Processing = 5
        }

        public enum LimitProductConfigStatus : byte
        {
            Pending = 0, //chờ duyệt
            Approved = 1, //đã duyệt
            Cancel = 3, //Đã hủy
            Applying = 2, //Đang áp dụng
            NotApply = 4, //Chưa ap dụng
            StopApply = 5, //Ngừng áp dụng
            Delete = 6 //Ngừng áp dụng
        }

        public enum BlockBalanceStatus : byte
        {
            Pending = 0, //chờ duyệt
            Approved = 1, //đã duyệt
        }

        public enum BlockBalanceType : byte
        {
            Block = 1,
            UnBlock = 2
        }

        public enum PayBatchBillStatus : byte
        {
            Pending = 0, //chờ duyệt
            Approved = 1, //đã duyệt
            Cancel = 3, //Đã hủy
            Error = 4,
            Processing = 5
        }

        public enum SystemTransferStatus : byte
        {
            Pending = 0, //chờ duyệt
            Approved = 1, //đã duyệt
            Cancel = 3, //Đã hủy
            Error = 4, //Đã hủy
            Processing = 5, //Đã hủy
        }

        public enum AccountActivityType
        {
            Default = 99,
            AssignSale = 1,
            ConvertSale = 2,
            UpdateSale = 3,
            Lock = 4,
            UnLock = 5,
            Verify,
            ChangeUserName = 6,
        }

        public enum PayBillCustomerStatus : byte
        {
            Default = 99,
            Unpaid = 0,
            Paid = 1
        }

        public enum SendNotificationStatus : byte
        {
            Pending = 0,
            Approved = 1,
            Cancel = 3,
            Published = 2,
            Failed = 4,
            CancelSchedule = 5,
            Default = 99
        }

        public enum SaleRequestType : byte
        {
            Topup = 1,
            TopupPartner = 2,
            PayBill = 3,
            PinCode = 4,
            TopupList = 5,
            PayBillList = 6
        }


        public enum BatchLotRequestStatus : byte
        {
            Init = 0,
            Completed = 1,
            Process = 2,
            Stop = 3
        }

        public enum SaleRequestStatus : byte
        {
            Init = 0,
            Success = 1,
            Canceled = 2,
            Failed = 3,
            TimeOver = 4,
            InProcessing = 6,
            ProcessTimeout = 7,
            WaitForResult = 8,
            Paid = 9, //Đã thanh toán
            Mapping = 10, //GHép dc 1 phần
            Undefined = 99
        }

        public enum AgentPartnerContactInfoType
        {
            Director = 1,
            Technical = 2,
            Comparator = 3,
            Accountant = 4,
        }

        public enum MethodReceivePassFile : byte
        {
            Sms = 1,
            Email = 2,
        }

        public enum PartnerServiceConfigurationStatus : byte
        {
            Init = 0, //Khởi tạo
            Active = 1, //Hoạt động
            Lock = 2 //Khóa
        }

        public enum StockTransStatus : byte
        {
            Init = 0,
            Active = 1,
            Delete = 3,
            Undefined = 99
        }

        public enum EventTypeDisplay
        {
            Slide = 0,
            Block = 1,
        }

        public enum ViewMode
        {
            Slide = 0,
            Block = 1,
        }

        public enum SaleTicketSatus : byte
        {
            Coming = 0,
            InSale = 1,
            ExpiredSale = 2
        }

        public enum EventStatus : byte
        {
            /// <summary>
            /// Chờ duyệt
            /// </summary>
            Init = 0,

            /// <summary>
            /// Đã duyệt /đang diễn ra
            /// </summary>
            Active = 1,

            /// <summary>
            /// Sắp diễn ra
            /// </summary>
            Upcoming = 2,

            /// <summary>
            /// Đã keets thúc
            /// </summary>
            Expired = 3,

            /// <summary>
            /// Huyr
            /// </summary>
            Cancel = 4,

            /// <summary>
            /// Tạm dừng
            /// </summary>
            Pause = 5
        }
    }

    public enum CurrencyCode : byte
    {
        VND = 1,
        DEBT = 2,
        GSTAR = 3,
        COMM = 4
    }

    public enum RequestToAgentStatus : byte
    {
        Init = 0,
        Approval = 1,
        Cancel = 2,
        Withdraw = 3,
        Expired = 4,
    }

    public enum RequestToAgentType : byte
    {
        Agent = 1,
        Collaborator = 2,
        ChildCollaborator = 3, /// yêu cầu trở thành ctv con
    }

    public enum BankType : byte
    {
        Default = 0, //Mặc định
        BankForDeposit = 1, //Bank nhận tiền CK
        BankLinkAccount = 2 //Bank dùng liên kết 
    }

    public enum BankConnectType : byte
    {
        WebView = 1,
        Api = 2,
        Sdk = 3
    }

    public enum NotificationCate
    {
        Default = 1,
        News = 2
    }

    public enum CommissionPolicyStatus : byte
    {
        Pending = 0, //chờ duyệt
        Approved = 1, //đã duyệt
        Cancel = 3, //Đã hủy
        Applying = 2, //Đang áp dụng
        NotApply = 4, //Chưa ap dụng
        StopApply = 5 //Ngừng áp dụng
    }

    public enum BankAccountStatus
    {
        Active = 1,
        Lock = 0
    }

    public enum WithdrawStatus : byte
    {
        Pending = 0,
        Approved = 1,
        Canceled = 3,
        Deleted = 4,
        Error = 5,
        Processing = 6
    }

    public enum WithdrawType : byte
    {
        Commission = 1
    }

    public enum PaymentMethod : byte
    {
        Default = 99,
        Wallet = 1,
        PaymentGw = 2,
        GSimBank = 3,
    }

    public enum PaymentChannel : byte
    {
        Default = 0,
        Atm = 1,
        QrCode = 2
    }

    public enum BankGateRequestStatus : byte
    {
        Init = 0,
        Success = 1,
        Pending = 2,
        Fail = 3,
        Cancel = 4,
        WaitResult = 5,
        Default = 99,
    }


    public enum PaymentGwProvider
    {
        MSB,
        VCB,
        TCB,
        FAKE,
        ECOPAY,
        VPBANK,
    }

    public static class PaymentGwProviderConst
    {
        public const string MSB = "MSB";
        public const string VCB = "VCB";
        public const string ACB = "ACB";
        public const string TCB = "TCB";
        public const string FAKE = "FAKE";
        public const string ECOPAY = "ECOPAY";
        public const string ECOPAY_GMB = "ECOPAY_GMB";
        public const string VPBANK = "VPBANK";
    }

    public enum Gender : byte
    {
        Male = 1,
        Female = 2,
        Unknown = 3
    }

    public enum RequestToChangeNumberStatus : byte
    {
        Init = 0, //Khởi tạo
        Success = 1, //Hoàn thành xử lý cả 2 bên (Trạng thái thành công cuối)
        Pending = 2, //Đã gửi yêu cầu sang GMB thành công và chờ duyệt
        Approval = 3, //GMB đã confirm duyệt
        Cancel = 4, //GMB hủy yêu cầu
        Error = 5, //Lỗi
        Default = 99
    }

    public class GmobileType
    {
        public const string ChangeNumber = "ChangeNumber";

        public const string RealNumber = "RealNumber";

        public const string VirtualNumber = "VirtualNumber";

        public const string GSimNoActive = "GSimNoActive";

        public const string PackageNoActive = "PackageNoActive";

        public const string Convert2GNumber = "Convert2GNumber";

        public const string ConvertPackage = "ConvertPackage";

        public const string ConvertContract = "ConvertContract";

        public const string EvictionNumber = "EvictionNumber";

        public const string EvictionNoActive = "EvictionNoActive";

        public const string ActiveNumber = "ActiveNumber";

        public const string FStarGSim = "FStarGSim";

        public const string NoEkyc = "NoEkyc";
    }

    public enum NotificationActionType : byte
    {
        Default = 0,
        InApp = 1,
        WebView = 3,
        WebBrowser = 4
    }

    public enum NotificationRequestType : byte
    {
        Accounts = 0,
        File = 1,
        Default = 99
    }

    public enum NotificationType : byte
    {
        Notification = 1,
        Promotion = 2,
        New = 3,
        Other = 4,
        Default = 99
    }

    public enum CalculateCommissionType : byte
    {
        NotFull = 0,
        Full = 1,
    }

    public enum CommissionPayType : byte
    {
        /// <summary>
        /// trả ngay
        /// </summary>
        PayNow = 0,

        /// <summary>
        /// trả theo kì
        /// </summary>
        PayPeriod = 1,
    }

    public enum DiscountCommissionType
    {
        Percentage = 0,
        VND = 1,
    }

    public enum OrderTypeRequest
    {
        Asc = 1,
        Desc
    }

    public enum PeriodType : byte
    {
        Day = 1,
        Week = 2,
        Month = 3,
        Quarter = 4,
        Year = 5
    }

    public enum PolicyStatus : byte
    {
        Draft = 0,
        WaitingApproval = 1,
        Approved = 2,
        Stopped = 3,
        ComingSoon = 4,
    }

    public enum CurrencyExchangePolicyStatus : byte
    {
        Init = 0,
        Success = 1,
        Canceled = 2,
        Failed = 3,
    }

    public enum VotingEventStatus : byte
    {
        Pending = 0, // Chờ duyệt
        ComingSoon = 2, // Sắp diễn ra
        InProgress = 1, // Đang diễn ra
        Finished = 3, // Đã kết thúc
        Stopped = 5, // Tạm dừng
        Canceled = 4, // Đã huỷ
        Default = 99
    }

    public enum VotingRoundStatus : byte
    {
        Pending = 0, // Chờ duyệt
        ComingSoon = 2, // Sắp diễn ra
        InProgress = 1, // Đang diễn ra
        Finished = 3, // Đã kết thúc
        Stopped = 5, // Tạm dừng
        Canceled = 4, // Đã huỷ
        Default = 99
    }

    public enum VotingShowResultType : byte
    {
        Total = 0,
        Round = 1,
        Time = 2
    }

    public enum MembershipType
    {
        FSTAR,
        GSTAR
    }

    public enum MembershipPeriodType
    {
        Minute,
        Day,
        Week,
        Month,

        //Quarter,
        Year = 5,
        Forever
    }

    public enum MembershipServiceStatus
    {
        Init,
        Active,
        Lock
    }

    public enum FeePolicyStatus : byte
    {
        Init = 0,
        Success = 1,
        Canceled = 2,
        Stop = 3,
    }

    public enum SystemFeePolicyPeriodType
    {
        Day = 1,
        Month,
        Year,
        Eu
    }
}

public enum GmobileStepStatus : byte
{
    Init = 0, //Khởi tao
    BlockSim = 1, //LockSim ,
    Add_kit = 2, //Gan sim ,
    Card_ekyc = 3, //Gán chủ thuê bao ,
    Confirm_ekyc = 4, //xac nhan thong tin
    Selfie_ekyc = 5, //chan dung
    Signature_ekyc = 6, //chu ky ,
    Remove_ekyc = 7, //huy ,
    Undefined = 99
}

public enum GmobileRegisterStatus : byte
{
    Init = 0, //Khởi tạo
    InProcessing = 2, //Đang xử lý    
    Success = 1, //Thành công   
    Complete = 5, //Hoàn tất
    Payment = 6, //Thanh toán
    Failed = 3, //Lỗi-Từ chối ,  
    Canceled = 4, //Hủy
    Undefined = 99
}

public enum GmobileNumberStatus : byte
{
    Init = 0, //Khởi tạo   
    Success = 1, //Hoạt động,
    Use = 2, //Gán cho khách hàng
    Sale = 5, //Bán
    Lock = 3, //Khóa 
    Canceled = 4, //Hủy
    Inventory = 6,
    Undefined = 99
}

public enum GmobileAssignStatus : byte
{
    Init = 0,
    Success = 1,
    Stop = 3,
    Canceled = 4,
    Undefined = 99
}

public enum GmobileSerialStatus : byte
{
    Init = 0, //Khởi tạo   
    Success = 1, //Hoạt động
    Use = 2, //Sim được gán
    Sale = 3, //Sim đã bán
    Lock = 4, //Sim bị khóa 
    Canceled = 5, //Sim bị hủy
    Forget = 6, //Sim bị mất
    Broken = 7, //Sim bị hỏng
    Error = 8, //Sim bị lỗi
    Inactive = 9, //Sim Không hoạt động
    Undefined = 99
}

public enum GmobileStoreStatus : byte
{
    Init = 0, //Khởi tạo   
    Success = 1, //Hoat dong   ,       
    Lock = 2, //Khoa 
    Undefined = 99
}

public enum GmobileConfigStatus : byte
{
    Init = 0, //Khởi tạo   
    Success = 1, //Hoat dong   ,       
    Stop = 2, //Khóa 
    Canceled = 3, //Hủy
    Undefined = 99
}

public enum GmobileSimStatus : byte
{
    Init = 0,
    Activate = 1,
    NotActivate = 2,
    WaitActivate = 5,
    Lock = 3,
    Undefined = 99
}

public enum GmobileBatchStatus : byte
{
    Init = 0, //Khởi tạo   
    Success = 1, //Hoạt động,                
    Lock = 3, //Khóa 
    Canceled = 4, //Hủy
    Inventory = 6, //Cần kiểm kê lại
    Inactive = 7, //Không hoạt động
    Revocation = 8, //Thu hồi
    Undefined = 99
}

public enum NotificationSystemAccountType : byte
{
    //System = 0, //hệ thống
    Company = 1, //công ty
    Agent = 2, //Đại lý
    Staff = 4, //nhân viên tài khoản
    ManagementLevel = 3, //Cấp quản lý
    Collaborator = 5, //cộng tác viên
    BusinessMember = 6, //thành viên kinh doanh
    AgentApi = 7, //tk kết nối api
    StaffApi = 8, //nv api
    EndUser = 100, //EndUser

    //Default = 99,
    AllSignedIn = 254,
    AllApplication = 255
}

public enum CandidateStatus
{
    Active = 1,
    Created = 0,
    Inactive = 3
}

public enum ApproveCommissionStatus : byte
{
    /// <summary>
    /// chờ phê duyệt
    /// </summary>
    Waiting = 0,

    /// <summary>
    /// đã phê duyệt sẵn sàng trả thưởng
    /// </summary>
    Approved = 1
}

public enum CommissionStatus : byte
{
    /// <summary>
    /// chờ phê duyệt
    /// </summary>
    Waiting = 0,

    /// <summary>
    /// đã phê duyệt sẵn sàng trả thưởng
    /// </summary>
    Approved = 1,

    /// <summary>
    /// chi trả thành công
    /// </summary>
    PaymentPaid = 2,
}

public class EventTicketingConst
{
    public enum TicketType
    {
        OneTime = 1,
        Unlimited = 2
    }

    public enum EventForAgeType
    {
        UnLimited = 0,
        Over16 = 1,
        Over18 = 2
    }

    public enum RealityShowStatus : byte
    {
        Init = 0,
        Active = 1,
        Upcoming = 2,
        Expired = 3,
        Cancel = 4,
        Pause = 5
    }

    public enum EventShowStatus : byte
    {
        Init = 0,
        Active = 1,
        Upcoming = 2,
        Expired = 3,
        Cancel = 4,
        Pause = 5
    }

    public enum EventTicketSaleType
    {
        SaleForZone = 1, //Bán theo khu vực
        SaleForZoneNumber = 2, //Theo khu vực có số
        SaleForNumber = 3 //Theo khu vự
    }

    public enum TicketStatus
    {
        /// <summary>
        /// Chưa bán
        /// </summary>
        Init = 0, //Chưa dùng
        Activated = 1, //Đã kích hoạt
        Used = 2, //Đã sử dụng
        Expired = 3, //Vé đã hết hạn
        SaleExpired = 4, //Quá thời gian
        Sold = 5, //Đã bán
        Disabled = 6, //Không mở bán
        Selected = 7,
        Empty = 8, //Vè trống
        Hold = 9 //Giữ bởi ng khác
    }

    public enum SaleTicketStatus
    {
        Coming = 0,
        InSale = 1,
    }

    public enum TicketSeatStatus
    {
        Init = 0,
        Activated = 1,
        Used = 2,
        Expired = 3,
        SaleExpired = 4,
        Sold = 5,
        Disabled = 6,
        Selected = 7,
        Empty = 8
    }

    public enum TicketGiftStatus
    {
        /// <summary>
        /// Đang chờ duyệt tặng
        /// </summary>
        Pending = 0,

        /// <summary>
        /// Đã duyệt tặng
        /// </summary>
        Approved = 1,

        /// <summary>
        /// Đã hủy tặng
        /// </summary>
        Canceled = 2,

        /// <summary>
        /// Lỗi
        /// </summary>
        Error = 3
    }

    public enum TicketClassType
    {
        /// </summary>
        Default = 0,
        Seat = 1,
        Random = 2
    }

    public enum TicketScanType
    {
        /// </summary>
        Default = 1, //Quét trên hệ thống iZOTA
        Provider = 2 //Quét trên hệ thống NCC
    }
}

public class AppPageBuilderConst
{
    public enum ComponentBlockType : byte
    {
        Block = 1,
        Slider = 2,
        Banner = 3,
        Favourite = 4,
        Navigation = 5,
        MainBar = 6, //Main bar
        DynamicItems = 7, //Block lấy danh sách item từ 1 api khác
        BannerItem = 8, //block có item là banner
        PopUp = 9,
        Default = 99
    }

    public enum EffectType : byte
    {
        SlideToLeft = 1,
        SlideToRight = 2,
        Rolling = 3
    }

    public enum ViewType : byte
    {
        Normal = 0,
        GridView = 1,
        ListView = 2,
        PageList = 3,
        Slider = 4
    }

    public enum ItemLayout : byte
    {
        Circle = 1,
    }

    public enum ReferenceType : byte
    {
        Page = 1,
        WebView = 2,
        Browser = 3,
        ShowMoreDialog = 4,
        ShowMoreDialogFull = 5,
        CallApi = 6
    }

    public enum PageType : byte
    {
        Normal,
        HomePage
    }
}

public class GstarRedemptionConst
{
    public enum RedemptionProductType : byte
    {
        Normal = 1,
        Voucher = 2,
        Default = 99
    }
}

public enum EKycAuthorizationRequestStatus : byte
{
    Init = 0,
    Success = 1,
    Cancel = 2,
    Expired = 3,
    Processing = 4
}

public enum EKycAuthorizationRequestType : byte
{
    Full = 1,
    Nfc = 2
}

public class PositionItem
{
    public int Id { get; set; }
    public int newPosition { get; set; }
}

public static class UserSourceType
{
    public static string VPB = "VPB";
}

public static class OrganizationUnitTypeConst
{
    public static string S99 = "S99";
    public static string SAYMEE = "SAYMEE";
    public static string BANk_MSB = "BANk_MSB";
}

public class VoucherManagementConst
{
    public enum VoucherStatus : byte
    {
        ACTIVE = 1,
        INACTIVE = 2,
        EXPIRED = 3,
        REDEEMED = 4,
        REFUNDED = 5,
        SUSPENDED = 6,
        CANCELLED = 7,
        ASSIGNED = 8,
        REWARD = 9,
        HOLD = 10,
    }

    public enum IssueType : byte
    {
        GiftCard = 1,
        Sellable = 2,
        Mission = 3,
    }

    public enum VoucherType : byte
    {
        GIFT_VOUCHER = 1,
        DISCOUNT_VOUCHER = 2,
        REFUND_VOUCHER = 3,
        REFERRAL_VOUCHER = 4,
        CASHBACK_VOUCHER = 5,
        LOYALTY_VOUCHER = 6,
        PROMOTIONAL_VOUCHER = 7,
        LUCKY_DRAW_VOUCHER = 8
    }

    public enum DiscountVoucherType : byte
    {
        PERCENTAGE = 1,
        AMOUNT = 2,

        // FREE_SHIPPING = 3,
        UNIT = 3,

        // BUY_X_GET_Y = 5,
        // BUY_X_GET_Y_PERCENTAGE = 6,
        // BUY_X_GET_Y_AMOUNT = 7,
        // BUY_X_GET_Y_FREE_SHIPPING = 8,
        // BUY_X_GET_Y_UNIT = 9,
        // BUY_X_GET_Y_FREE_PRODUCT = 10,
        FIXED = 4,
        CASHBACK = 5,
    }

    public enum DiscountEffectType : byte
    {
        APPLY_TO_ORDER = 1,
        APPLY_TO_ITEMS = 2
    }

    public enum CampaignType : byte
    {
        LOYALTY_PROGRAM = 1,
        PROMOTION = 2,
        DISCOUNT_COUPONS = 3,
        GIFT_VOUCHERS = 4,
        REFERRAL_PROGRAM = 5
    }

    public enum CampaignStatus : byte
    {
        DRAFT,
        ACTIVE,
        EXPIRED,
        CANCELLED,
        UPCOMING,
        INPROGRESS
    }

    public enum VoucherApplyType : byte
    {
        Order = 1,
    }

    public enum CustomerApplyType : byte
    {
        AllCustomer = 0,
        NewCustomer = 1,
        OldCustomer = 2
    }

    public enum OrgStaffAccountType : byte
    {
    }

    public enum AssignTypes : byte
    {
        Default = 0,
        Received = 3,
        NotCollect = 1,
        MustCollect = 2,
    }

    public enum VoucherAssignmentsStatus : byte
    {
        Add = 1,
        Update = 2,
        Delete = 3,
    }
}