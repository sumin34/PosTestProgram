using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constants
{
    class Constant
    {
        
        /////////////////////////////////////////////////////////////////////
        // OPOS "State" Property publicants
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_S_CLOSED = 1;
        public static int OPOS_S_IDLE = 2;
        public static int OPOS_S_BUSY = 3;
        public static int OPOS_S_ERROR = 4;


        /////////////////////////////////////////////////////////////////////
        // OPOS "ResultCode" Property publicants
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_SUCCESS = 0;
        public static int OPOS_E_CLOSED = 101;
        public static int OPOS_E_CLAIMED = 102;
        public static int OPOS_E_NOTCLAIMED = 103;
        public static int OPOS_E_NOSERVICE = 104;
        public static int OPOS_E_DISABLED = 105;
        public static int OPOS_E_ILLEGAL = 106;
        public static int OPOS_E_NOHARDWARE = 107;
        public static int OPOS_E_OFFLINE = 108;
        public static int OPOS_E_NOEXIST = 109;
        public static int OPOS_E_EXISTS = 110;
        public static int OPOS_E_FAILURE = 111;
        public static int OPOS_E_TIMEOUT = 112;
        public static int OPOS_E_BUSY = 113;
        public static int OPOS_E_EXTENDED = 114;
        public static int OPOS_E_DEPRECATED = 115; // (added in 1.11)

        public static int OPOSERR = 100; // Base for ResultCode errors.
        public static int OPOSERREXT = 200; // Base for ResultCodeExtendedErrors.


        /////////////////////////////////////////////////////////////////////
        // OPOS "ResultCodeExtended" Property publicants
        /////////////////////////////////////////////////////////////////////

        // The following applies to ResetStatistics and UpdateStatistics.
        public static int OPOS_ESTATS_ERROR = 280; // (added in 1.8)
        public static int OPOS_ESTATS_DEPENDENCY = 282; // (added in 1.10)
                                                 // The following applies to CompareFirmwareVersion and UpdateFirmware.
        public static int OPOS_EFIRMWARE_BAD_FILE = 281; // (added in 1.9)


        /////////////////////////////////////////////////////////////////////
        // OPOS "OpenResult" Property publicants (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        // The following can be set by the control object.
        //  - Control Object already open.
        public static int OPOS_OR_ALREADYOPEN = 301;
        //  - The registry does not contain a key for the specified device name.
        public static int OPOS_OR_REGBADNAME = 302;
        //  - Could not read the device name key's default value, or
        //     could not convert this Prog ID to a valid Class ID.
        public static int OPOS_OR_REGPROGID = 303;
        //  - Could not create a service object instance, or
        //     could not get its IDispatch interface.
        public static int OPOS_OR_CREATE = 304;
        //  - The service object does not support one or more of the
        //     method required by its release.
        public static int OPOS_OR_BADIF = 305;
        //  - The service object returned a failure status from its
        //     open call, but doesn't have a more specific failure code.
        public static int OPOS_OR_FAILEDOPEN = 306;
        //  - The service object major version number is not 1.
        public static int OPOS_OR_BADVERSION = 307;

        // The following can be returned by the service object if it
        // returns a failure status from its open call.
        //  - Port access required at open, but configured port
        //     is invalid or inaccessible.
        public static int OPOS_ORS_NOPORT = 401;
        //  - Service Object does not support the specified device.
        public static int OPOS_ORS_NOTSUPPORTED = 402;
        //  - Configuration information error.
        public static int OPOS_ORS_CONFIG = 403;
        //  - Errors greater than this value are SO-specific.
        public static int OPOS_ORS_SPECIFIC = 450;


        /////////////////////////////////////////////////////////////////////
        // OPOS "BinaryConversion" Property publicants (added in 1.2)
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_BC_NONE = 0;
        public static int OPOS_BC_NIBBLE = 1;
        public static int OPOS_BC_DECIMAL = 2;


        /////////////////////////////////////////////////////////////////////
        // "CheckHealth" Method: "Level" Parameter publicants
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_CH_INTERNAL = 1;
        public static int OPOS_CH_EXTERNAL = 2;
        public static int OPOS_CH_INTERACTIVE = 3;


        /////////////////////////////////////////////////////////////////////
        // OPOS "CapPowerReporting", "PowerState", "PowerNotify" Property
        //   publicants (added in 1.3)
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_PR_NONE = 0;
        public static int OPOS_PR_STANDARD = 1;
        public static int OPOS_PR_ADVANCED = 2;

        public static int OPOS_PN_DISABLED = 0;
        public static int OPOS_PN_ENABLED = 1;

        public static int OPOS_PS_UNKNOWN = 2000;
        public static int OPOS_PS_ONLINE = 2001;
        public static int OPOS_PS_OFF = 2002;
        public static int OPOS_PS_OFFLINE = 2003;
        public static int OPOS_PS_OFF_OFFLINE = 2004;


        /////////////////////////////////////////////////////////////////////
        // "CompareFirmwareVersion" Method: "Result" Parameter publicants
        //   (added in 1.9)
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_CFV_FIRMWARE_OLDER = 1;
        public static int OPOS_CFV_FIRMWARE_SAME = 2;
        public static int OPOS_CFV_FIRMWARE_NEWER = 3;
        public static int OPOS_CFV_FIRMWARE_DIFFERENT = 4;
        public static int OPOS_CFV_FIRMWARE_UNKNOWN = 5;


        /////////////////////////////////////////////////////////////////////
        // "ErrorEvent" Event: "ErrorLocus" Parameter publicants
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_EL_OUTPUT = 1;
        public static int OPOS_EL_INPUT = 2;
        public static int OPOS_EL_INPUT_DATA = 3;


        /////////////////////////////////////////////////////////////////////
        // "ErrorEvent" Event: "ErrorResponse" publicants
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_ER_RETRY = 11;
        public static int OPOS_ER_CLEAR = 12;
        public static int OPOS_ER_CONTINUEINPUT = 13;


        /////////////////////////////////////////////////////////////////////
        // "StatusUpdateEvent" Event: Common "Status" publicants
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_SUE_POWER_ONLINE = 2001; // (added in 1.3)
        public static int OPOS_SUE_POWER_OFF = 2002; // (added in 1.3)
        public static int OPOS_SUE_POWER_OFFLINE = 2003; // (added in 1.3)
        public static int OPOS_SUE_POWER_OFF_OFFLINE = 2004; // (added in 1.3)

        public static int OPOS_SUE_UF_PROGRESS = 2100; // (added in 1.9)
        public static int OPOS_SUE_UF_COMPLETE = 2200; // (added in 1.9)
        public static int OPOS_SUE_UF_COMPLETE_DEV_NOT_RESTORED = 2205; // (added in 1.9)
        public static int OPOS_SUE_UF_FAILED_DEV_OK = 2201; // (added in 1.9)
        public static int OPOS_SUE_UF_FAILED_DEV_UNRECOVERABLE = 2202; // (added in 1.9)
        public static int OPOS_SUE_UF_FAILED_DEV_NEEDS_FIRMWARE = 2203; // (added in 1.9)
        public static int OPOS_SUE_UF_FAILED_DEV_UNKNOWN = 2204; // (added in 1.9)


        /////////////////////////////////////////////////////////////////////
        // General publicants
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_FOREVER = -1; // (added in 1.2)




        /////////////////////////////////////////////////////////////////////
        // Printer Station publicants
        /////////////////////////////////////////////////////////////////////

        public static int PTR_S_JOURNAL = 1;
        public static int PTR_S_RECEIPT = 2;
        public static int PTR_S_SLIP = 4;

        public static int PTR_S_JOURNAL_RECEIPT = 0x0003;
        public static int PTR_S_JOURNAL_SLIP = 0x0005;
        public static int PTR_S_RECEIPT_SLIP = 0x0006;

        public static int PTR_TWO_RECEIPT_JOURNAL = 0x8003; // (added in 1.3)
        public static int PTR_TWO_SLIP_JOURNAL = 0x8005; // (added in 1.3)
        public static int PTR_TWO_SLIP_RECEIPT = 0x8006; // (added in 1.3)


        /////////////////////////////////////////////////////////////////////
        // "CapCharacterSet" Property publicants (added in 1.1)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_CCS_ALPHA = 1;
        public static int PTR_CCS_ASCII = 998;
        public static int PTR_CCS_KANA = 10;
        public static int PTR_CCS_KANJI = 11;
        public static int PTR_CCS_UNICODE = 997; // (added in 1.5)


        /////////////////////////////////////////////////////////////////////
        // "CharacterSet" Property publicants
        /////////////////////////////////////////////////////////////////////

        public static int PTR_CS_UNICODE = 997; // (added in 1.5)
        public static int PTR_CS_ASCII = 998;
        public static int PTR_CS_WINDOWS = 999;
        public static int PTR_CS_ANSI = 999;


        /////////////////////////////////////////////////////////////////////
        // "ErrorLevel" Property publicants (added in 1.1)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_EL_NONE = 1;
        public static int PTR_EL_RECOVERABLE = 2;
        public static int PTR_EL_FATAL = 3;


        /////////////////////////////////////////////////////////////////////
        // "MapMode" Property publicants
        /////////////////////////////////////////////////////////////////////

        public static int PTR_MM_DOTS = 1;
        public static int PTR_MM_TWIPS = 2;
        public static int PTR_MM_ENGLISH = 3;
        public static int PTR_MM_METRIC = 4;


        /////////////////////////////////////////////////////////////////////
        // "CapXxxColor" Property publicants
        /////////////////////////////////////////////////////////////////////

        public static long PTR_COLOR_PRIMARY = 0x00000001;
        public static long PTR_COLOR_CUSTOM1 = 0x00000002;
        public static long PTR_COLOR_CUSTOM2 = 0x00000004;
        public static long PTR_COLOR_CUSTOM3 = 0x00000008;
        public static long PTR_COLOR_CUSTOM4 = 0x00000010;
        public static long PTR_COLOR_CUSTOM5 = 0x00000020;
        public static long PTR_COLOR_CUSTOM6 = 0x00000040;
        public static long PTR_COLOR_CYAN = 0x00000100;
        public static long PTR_COLOR_MAGENTA = 0x00000200;
        public static long PTR_COLOR_YELLOW = 0x00000400;
        public static long PTR_COLOR_FULL = 0x80000000;


        /////////////////////////////////////////////////////////////////////
        // "CapXxxCartridgeSensor" and  "XxxCartridgeState" Property publicants
        //   (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        public static long PTR_CART_UNKNOWN = 0x10000000;
        public static long PTR_CART_OK = 0x00000000;
        public static long PTR_CART_REMOVED = 0x00000001;
        public static long PTR_CART_EMPTY = 0x00000002;
        public static long PTR_CART_NEAREND = 0x00000004;
        public static long PTR_CART_CLEANING = 0x00000008;


        /////////////////////////////////////////////////////////////////////
        // "CartridgeNotify" Property publicants (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_CN_DISABLED = 0x00000000;
        public static int PTR_CN_ENABLED = 0x00000001;


        /////////////////////////////////////////////////////////////////////
        // "PageModeDescriptor" Property publicants (added in 1.9)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_PM_BITMAP = 0x00000001;
        public static int PTR_PM_BARCODE = 0x00000002;
        public static int PTR_PM_BM_ROTATE = 0x00000004;
        public static int PTR_PM_BC_ROTATE = 0x00000008;
        public static int PTR_PM_OPAQUE = 0x00000010;


        /////////////////////////////////////////////////////////////////////
        // "PageModePrintDirection" Property publicants (added in 1.9)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_PD_LEFT_TO_RIGHT = 1;
        public static int PTR_PD_BOTTOM_TO_TOP = 2;
        public static int PTR_PD_RIGHT_TO_LEFT = 3;
        public static int PTR_PD_TOP_TO_BOTTOM = 4;


        /////////////////////////////////////////////////////////////////////
        // "CutPaper" Method publicant
        /////////////////////////////////////////////////////////////////////

        public static int PTR_CP_FULLCUT = 100;


        /////////////////////////////////////////////////////////////////////
        // "PageModePrint" Method: "Control" Parameter publicants (added in 1.9)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_PM_PAGE_MODE = 1;
        public static int PTR_PM_PRINT_SAVE = 2;
        public static int PTR_PM_NORMAL = 3;
        public static int PTR_PM_CANCEL = 4;


        /////////////////////////////////////////////////////////////////////
        // "PrintBarCode" Method publicants:
        /////////////////////////////////////////////////////////////////////

        //** "Alignment" Parameter
        //     Either the distance from the left-most print column to the start
        //     of the bar code, or one of the following:

        public static int PTR_BC_LEFT = -1;
        public static int PTR_BC_CENTER = -2;
        public static int PTR_BC_RIGHT = -3;

        //** "TextPosition" Parameter

        public static int PTR_BC_TEXT_NONE = -11;
        public static int PTR_BC_TEXT_ABOVE = -12;
        public static int PTR_BC_TEXT_BELOW = -13;

        //** "Symbology" Parameter:

        //    - One dimensional symbologies
        /*public static int PTR_BCS_UPCA = 101;  // Digits
        public static int PTR_BCS_UPCE = 102;  // Digits
        public static int PTR_BCS_JAN8 = 103;  // = EAN 8
        public static int PTR_BCS_EAN8 = 103;  // = JAN 8 (added in 1.2)
        public static int PTR_BCS_JAN13 = 104;  // = EAN 13
        public static int PTR_BCS_EAN13 = 104;  // = JAN 13 (added in 1.2)
        public static int PTR_BCS_TF = 105;  // (Discrete 2 of 5) Digits
        public static int PTR_BCS_ITF = 106;  // (Interleaved 2 of 5) Digits
        public static int PTR_BCS_Codabar = 107;  // Digits, -, $, :, /, ., +;
                                           //   4 start/stop characters
                                           //   (a, b, c, d)
        public static int PTR_BCS_Code39 = 108;  // Alpha, Digits, Space, -, .,
                                          //   $, /, +, %; start/stop (*)
                                          // Also has Full ASCII feature
        public static int PTR_BCS_Code93 = 109;  // Same characters as Code 39
        public static int PTR_BCS_Code128 = 110;  // 128 data characters

        //    - One dimensional symbologies (added in 1.2)
        public static int PTR_BCS_UPCA_S = 111;  // UPC-A with supplemental
                                          //   barcode
        public static int PTR_BCS_UPCE_S = 112;  // UPC-E with supplemental
                                          //   barcode
        public static int PTR_BCS_UPCD1 = 113;  // UPC-D1
        public static int PTR_BCS_UPCD2 = 114;  // UPC-D2
        public static int PTR_BCS_UPCD3 = 115;  // UPC-D3
        public static int PTR_BCS_UPCD4 = 116;  // UPC-D4
        public static int PTR_BCS_UPCD5 = 117;  // UPC-D5
        public static int PTR_BCS_EAN8_S = 118;  // EAN 8 with supplemental
                                          //   barcode
        public static int PTR_BCS_EAN13_S = 119;  // EAN 13 with supplemental
                                           //   barcode
        public static int PTR_BCS_EAN128 = 120;  // EAN 128
        public static int PTR_BCS_OCRA = 121;  // OCR "A"
        public static int PTR_BCS_OCRB = 122;  // OCR "B"*/

        //    - One dimensional symbologies (added in 1.8)
        public static int PTR_BCS_Code128_Parsed = 123;  // Code 128 with parsing
                                                  //        The following RSS publicants deprecated in 1.12.
                                                  //        Instead use the GS1DATABAR publicants below.
        public static int PTR_BCS_RSS14 = 131;  // Reduced Space Symbology - 14 digit GTIN
        public static int PTR_BCS_RSS_EXPANDED = 132;  // RSS - 14 digit GTIN plus additional fields

        //    - One dimensional symbologies (added in 1.12)
        public static int PTR_BCS_GS1DATABAR = 131;  // GS1 DataBar Omnidirectional
        public static int PTR_BCS_GS1DATABAR_E = 132;  // GS1 DataBar Expanded
        public static int PTR_BCS_GS1DATABAR_S = 133;  // GS1 DataBar Stacked Omnidirectional
        public static int PTR_BCS_GS1DATABAR_E_S = 134;  // GS1 DataBar Expanded Stacked

        //    - Two dimensional symbologies
        public static int PTR_BCS_PDF417 = 201;
        public static int PTR_BCS_MAXICODE = 202;

        //    - Two dimensional symbologies (added in 1.13)
        public static int PTR_BCS_DATAMATRIX = 203;  // Data Matrix
        public static int PTR_BCS_QRCODE = 204;  // QR Code
        public static int PTR_BCS_UQRCODE = 205;  // Micro QR Code
        public static int PTR_BCS_AZTEC = 206;  // Aztec
        public static int PTR_BCS_UPDF417 = 207;  // Micro PDF 417

        //    - Start of Printer-Specific bar code symbologies
        public static int PTR_BCS_OTHER = 501;


        /////////////////////////////////////////////////////////////////////
        // "PrintBitmap" and "PrintMemoryBitmap" Method publicants:
        /////////////////////////////////////////////////////////////////////

        //** "Width" Parameter
        //     Either bitmap width or:

        public static int PTR_BM_ASIS = -11;  // One pixel per printer dot

        //** "Alignment" Parameter
        //     Either the distance from the left-most print column to the start
        //     of the bitmap, or one of the following:

        public static int PTR_BM_LEFT = -1;
        public static int PTR_BM_CENTER = -2;
        public static int PTR_BM_RIGHT = -3;

        //** "Type" Parameter ("PrintMemoryBitmap" only)
        public static int PTR_BMT_BMP = 1;
        public static int PTR_BMT_JPEG = 2;
        public static int PTR_BMT_GIF = 3;


        /////////////////////////////////////////////////////////////////////
        // "RotatePrint" Method: "Rotation" Parameter publicants
        // "RotateSpecial" Property publicants
        /////////////////////////////////////////////////////////////////////

        public static int PTR_RP_NORMAL = 0x0001;
        public static int PTR_RP_RIGHT90 = 0x0101;
        public static int PTR_RP_LEFT90 = 0x0102;
        public static int PTR_RP_ROTATE180 = 0x0103;

        // For "RotatePrint", one or both of the following values may be
        // ORed with one of the above values.
        public static int PTR_RP_BARCODE = 0x1000; // (added in 1.7)
        public static int PTR_RP_BITMAP = 0x2000; // (added in 1.7)


        /////////////////////////////////////////////////////////////////////
        // "SetLogo" Method: "Location" Parameter publicants
        /////////////////////////////////////////////////////////////////////

        public static int PTR_L_TOP = 1;
        public static int PTR_L_BOTTOM = 2;


        /////////////////////////////////////////////////////////////////////
        // "TransactionPrint" Method: "Control" Parameter publicants (added in 1.1)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_TP_TRANSACTION = 11;
        public static int PTR_TP_NORMAL = 12;


        /////////////////////////////////////////////////////////////////////
        // "MarkFeed" Method: "Type" Parameter publicants (added in 1.5)
        // "CapRecMarkFeed" Property publicants (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_MF_TO_TAKEUP = 1;
        public static int PTR_MF_TO_CUTTER = 2;
        public static int PTR_MF_TO_CURRENT_TOF = 4;
        public static int PTR_MF_TO_NEXT_TOF = 8;


        /////////////////////////////////////////////////////////////////////
        // "ChangePrintSide" Method: "Side" Parameter publicants (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_PS_UNKNOWN = 0;
        public static int PTR_PS_SIDE1 = 1;
        public static int PTR_PS_SIDE2 = 2;
        public static int PTR_PS_OPPOSITE = 3;


        /////////////////////////////////////////////////////////////////////
        // "CapRecRuledLine" and "CapSlpRuledLine" Property publicants
        // "DrawRuledLine" Method: "LineDirection" Parameter publicants
        // (added in 1.13)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_RL_HORIZONTAL = 1;
        public static int PTR_RL_VERTICAL = 2;


        /////////////////////////////////////////////////////////////////////
        // "DrawRuledLine" Method: "LineStyle" Parameter publicants
        // (added in 1.13)
        /////////////////////////////////////////////////////////////////////

        public static int PTR_LS_SINGLE_SOLID_LINE = 1;
        public static int PTR_LS_DOUBLE_SOLID_LINE = 2;
        public static int PTR_LS_BROKEN_LINE = 3;
        public static int PTR_LS_CHAIN_LINE = 4;


        /////////////////////////////////////////////////////////////////////
        // "StatusUpdateEvent" Event: "Data" Parameter publicants
        /////////////////////////////////////////////////////////////////////

        public static int PTR_SUE_COVER_OPEN = 11;
        public static int PTR_SUE_COVER_OK = 12;
        public static int PTR_SUE_JRN_COVER_OPEN = 60;  // (added in 1.8)
        public static int PTR_SUE_JRN_COVER_OK = 61;  // (added in 1.8)
        public static int PTR_SUE_REC_COVER_OPEN = 62;  // (added in 1.8)
        public static int PTR_SUE_REC_COVER_OK = 63;  // (added in 1.8)
        public static int PTR_SUE_SLP_COVER_OPEN = 64;  // (added in 1.8)
        public static int PTR_SUE_SLP_COVER_OK = 65;  // (added in 1.8)

        public static int PTR_SUE_JRN_EMPTY = 21;
        public static int PTR_SUE_JRN_NEAREMPTY = 22;
        public static int PTR_SUE_JRN_PAPEROK = 23;

        public static int PTR_SUE_REC_EMPTY = 24;
        public static int PTR_SUE_REC_NEAREMPTY = 25;
        public static int PTR_SUE_REC_PAPEROK = 26;

        public static int PTR_SUE_SLP_EMPTY = 27;
        public static int PTR_SUE_SLP_NEAREMPTY = 28;
        public static int PTR_SUE_SLP_PAPEROK = 29;

        public static int PTR_SUE_JRN_CARTRIDGE_EMPTY = 41; // (added in 1.5)
        public static int PTR_SUE_JRN_CARTRIDGE_NEAREMPTY = 42; // (added in 1.5)
        public static int PTR_SUE_JRN_HEAD_CLEANING = 43; // (added in 1.5)
        public static int PTR_SUE_JRN_CARTRIDGE_OK = 44; // (added in 1.5)

        public static int PTR_SUE_REC_CARTRIDGE_EMPTY = 45; // (added in 1.5)
        public static int PTR_SUE_REC_CARTRIDGE_NEAREMPTY = 46; // (added in 1.5)
        public static int PTR_SUE_REC_HEAD_CLEANING = 47; // (added in 1.5)
        public static int PTR_SUE_REC_CARTRIDGE_OK = 48; // (added in 1.5)

        public static int PTR_SUE_SLP_CARTRIDGE_EMPTY = 49; // (added in 1.5)
        public static int PTR_SUE_SLP_CARTRIDGE_NEAREMPTY = 50; // (added in 1.5)
        public static int PTR_SUE_SLP_HEAD_CLEANING = 51; // (added in 1.5)
        public static int PTR_SUE_SLP_CARTRIDGE_OK = 52; // (added in 1.5)

        public static int PTR_SUE_IDLE = 1001;


        /////////////////////////////////////////////////////////////////////
        // "ResultCodeExtended" Property publicants
        /////////////////////////////////////////////////////////////////////

        public static int OPOS_EPTR_COVER_OPEN = 201; // (Several)
        public static int OPOS_EPTR_JRN_EMPTY = 202; // (Several)
        public static int OPOS_EPTR_REC_EMPTY = 203; // (Several)
        public static int OPOS_EPTR_SLP_EMPTY = 204; // (Several)
        public static int OPOS_EPTR_SLP_FORM = 205; // EndRemoval
        public static int OPOS_EPTR_TOOBIG = 206; // PrintBitmap
        public static int OPOS_EPTR_BADFORMAT = 207; // PrintBitmap
        public static int OPOS_EPTR_JRN_CARTRIDGE_REMOVED = 208; // (Several) (added in 1.5)
        public static int OPOS_EPTR_JRN_CARTRIDGE_EMPTY = 209; // (Several) (added in 1.5)
        public static int OPOS_EPTR_JRN_HEAD_CLEANING = 210; // (Several) (added in 1.5)
        public static int OPOS_EPTR_REC_CARTRIDGE_REMOVED = 211; // (Several) (added in 1.5)
        public static int OPOS_EPTR_REC_CARTRIDGE_EMPTY = 212; // (Several) (added in 1.5)
        public static int OPOS_EPTR_REC_HEAD_CLEANING = 213; // (Several) (added in 1.5)
        public static int OPOS_EPTR_SLP_CARTRIDGE_REMOVED = 214; // (Several) (added in 1.5)
        public static int OPOS_EPTR_SLP_CARTRIDGE_EMPTY = 215; // (Several) (added in 1.5)
        public static int OPOS_EPTR_SLP_HEAD_CLEANING = 216; // (Several) (added in 1.5)

        public static readonly Dictionary<string, int> OPOSErrorCodes = new Dictionary<string, int>
        {
            { "OPOS_S_CLOSED", 1 },
            { "OPOS_S_IDLE", 2 },
            { "OPOS_S_BUSY", 3 },
            { "OPOS_S_ERROR", 4 },

            // OPOS "ResultCode" Property
            { "OPOS_SUCCESS", 0 },
            { "OPOS_E_CLOSED", 101 },
            { "OPOS_E_CLAIMED", 102 },
            { "OPOS_E_NOTCLAIMED", 103 },
            { "OPOS_E_NOSERVICE", 104 },
            { "OPOS_E_DISABLED", 105 },
            { "OPOS_E_ILLEGAL", 106 },
            { "OPOS_E_NOHARDWARE", 107 },
            { "OPOS_E_OFFLINE", 108 },
            { "OPOS_E_NOEXIST", 109 },
            { "OPOS_E_EXISTS", 110 },
            { "OPOS_E_FAILURE", 111 },
            { "OPOS_E_TIMEOUT", 112 },
            { "OPOS_E_BUSY", 113 },
            { "OPOS_E_EXTENDED", 114 },
            { "OPOS_E_DEPRECATED", 115 },

            { "OPOSERR", 100 },
            { "OPOSERREXT", 200 },

            // OPOS "ResultCodeExtended" Property
            { "OPOS_ESTATS_ERROR", 280 },
            { "OPOS_ESTATS_DEPENDENCY", 282 },
            { "OPOS_EFIRMWARE_BAD_FILE", 281 },

            // OPOS "OpenResult" Property
            { "OPOS_OR_ALREADYOPEN", 301 },
            { "OPOS_OR_REGBADNAME", 302 },
            { "OPOS_OR_REGPROGID", 303 },
            { "OPOS_OR_CREATE", 304 },
            { "OPOS_OR_BADIF", 305 },
            { "OPOS_OR_FAILEDOPEN", 306 },
            { "OPOS_OR_BADVERSION", 307 },

            { "OPOS_ORS_NOPORT", 401 },
            { "OPOS_ORS_NOTSUPPORTED", 402 },
            { "OPOS_ORS_CONFIG", 403 },
            { "OPOS_ORS_SPECIFIC", 450 },

            { "OPOS_SUE_POWER_ONLINE", 2001 },
            { "OPOS_SUE_POWER_OFF", 2002 },
            { "OPOS_SUE_POWER_OFFLINE", 2003 },
            { "OPOS_SUE_POWER_OFF_OFFLINE", 2004 },

            { "OPOS_SUE_UF_PROGRESS", 2100 },
            { "OPOS_SUE_UF_COMPLETE", 2200 },
            { "OPOS_SUE_UF_COMPLETE_DEV_NOT_RESTORED", 2205 },
            { "OPOS_SUE_UF_FAILED_DEV_OK", 2201 },
            { "OPOS_SUE_UF_FAILED_DEV_UNRECOVERABLE", 2202 },
            { "OPOS_SUE_UF_FAILED_DEV_NEEDS_FIRMWARE", 2203 },
            { "OPOS_SUE_UF_FAILED_DEV_UNKNOWN", 2204 }
        };
        
        public static string GetErrorCodeName(int errorCode)
        {
            return OPOSErrorCodes.FirstOrDefault(x => x.Value == errorCode).Key ?? $"unkown errorcode : {errorCode}";
        }
    }
}
