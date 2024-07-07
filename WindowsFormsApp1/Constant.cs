using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Constant
    {
        /////////////////////////////////////////////////////////////////////
        //
        // Opos.h
        //
        //   General header file for OPOS Applications.
        //
        // Modification history
        // ------------------------------------------------------------------
        // 1995-12-08 OPOS Release 1.0                                   CRM
        // 1997-06-04 OPOS Release 1.2                                   CRM
        //   Add OPOS_FOREVER.
        //   Add BinaryConversion constants.
        // 1998-03-06 OPOS Release 1.3                                   CRM
        //   Add CapPowerReporting, PowerState, and PowerNotify constants.
        //   Add power reporting constants for StatusUpdateEvent.
        // 2000-09-24 OPOS Release 1.5                                   CRM
        //   Add OpenResult status constants.
        // 2004-10-26 OPOS Release 1.8                                   CRM
        //   Add "ResultCodeExtended" statistics constant.
        // 2005-04-29 OPOS Release 1.9                                   CRM
        //   Add CompareFirmwareVersion's Result constants.
        //   Add StatusUpdateEvent and ResultCodeExtended constants
        //     for firmware update.
        // 2006-03-15 OPOS Release 1.10                                  CRM
        //   Add another constant for firmware update.
        // 2007-01-30 OPOS Release 1.11                                  CRM
        //   Add ResultCode constant for deprecation.
        // 2008-08-30 OPOS Release 1.12                                  CRM
        //   Comment updates.
        //
        /////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////
        // OPOS "State" Property Constants
        /////////////////////////////////////////////////////////////////////

        const long OPOS_S_CLOSED = 1;
        const long OPOS_S_IDLE = 2;
        const long OPOS_S_BUSY = 3;
        const long OPOS_S_ERROR = 4;


        /////////////////////////////////////////////////////////////////////
        // OPOS "ResultCode" Property Constants
        /////////////////////////////////////////////////////////////////////

        const long OPOS_SUCCESS = 0;
        const long OPOS_E_CLOSED = 101;
        const long OPOS_E_CLAIMED = 102;
        const long OPOS_E_NOTCLAIMED = 103;
        const long OPOS_E_NOSERVICE = 104;
        const long OPOS_E_DISABLED = 105;
        const long OPOS_E_ILLEGAL = 106;
        const long OPOS_E_NOHARDWARE = 107;
        const long OPOS_E_OFFLINE = 108;
        const long OPOS_E_NOEXIST = 109;
        const long OPOS_E_EXISTS = 110;
        const long OPOS_E_FAILURE = 111;
        const long OPOS_E_TIMEOUT = 112;
        const long OPOS_E_BUSY = 113;
        const long OPOS_E_EXTENDED = 114;
        const long OPOS_E_DEPRECATED = 115; // (added in 1.11)

        const long OPOSERR = 100; // Base for ResultCode errors.
        const long OPOSERREXT = 200; // Base for ResultCodeExtendedErrors.


        /////////////////////////////////////////////////////////////////////
        // OPOS "ResultCodeExtended" Property Constants
        /////////////////////////////////////////////////////////////////////

        // The following applies to ResetStatistics and UpdateStatistics.
        const long OPOS_ESTATS_ERROR = 280; // (added in 1.8)
        const long OPOS_ESTATS_DEPENDENCY = 282; // (added in 1.10)
                                                 // The following applies to CompareFirmwareVersion and UpdateFirmware.
        const long OPOS_EFIRMWARE_BAD_FILE = 281; // (added in 1.9)


        /////////////////////////////////////////////////////////////////////
        // OPOS "OpenResult" Property Constants (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        // The following can be set by the control object.
        //  - Control Object already open.
        const long OPOS_OR_ALREADYOPEN = 301;
        //  - The registry does not contain a key for the specified device name.
        const long OPOS_OR_REGBADNAME = 302;
        //  - Could not read the device name key's default value, or
        //     could not convert this Prog ID to a valid Class ID.
        const long OPOS_OR_REGPROGID = 303;
        //  - Could not create a service object instance, or
        //     could not get its IDispatch interface.
        const long OPOS_OR_CREATE = 304;
        //  - The service object does not support one or more of the
        //     method required by its release.
        const long OPOS_OR_BADIF = 305;
        //  - The service object returned a failure status from its
        //     open call, but doesn't have a more specific failure code.
        const long OPOS_OR_FAILEDOPEN = 306;
        //  - The service object major version number is not 1.
        const long OPOS_OR_BADVERSION = 307;

        // The following can be returned by the service object if it
        // returns a failure status from its open call.
        //  - Port access required at open, but configured port
        //     is invalid or inaccessible.
        const long OPOS_ORS_NOPORT = 401;
        //  - Service Object does not support the specified device.
        const long OPOS_ORS_NOTSUPPORTED = 402;
        //  - Configuration information error.
        const long OPOS_ORS_CONFIG = 403;
        //  - Errors greater than this value are SO-specific.
        const long OPOS_ORS_SPECIFIC = 450;


        /////////////////////////////////////////////////////////////////////
        // OPOS "BinaryConversion" Property Constants (added in 1.2)
        /////////////////////////////////////////////////////////////////////

        const long OPOS_BC_NONE = 0;
        const long OPOS_BC_NIBBLE = 1;
        const long OPOS_BC_DECIMAL = 2;


        /////////////////////////////////////////////////////////////////////
        // "CheckHealth" Method: "Level" Parameter Constants
        /////////////////////////////////////////////////////////////////////

        const long OPOS_CH_INTERNAL = 1;
        const long OPOS_CH_EXTERNAL = 2;
        const long OPOS_CH_INTERACTIVE = 3;


        /////////////////////////////////////////////////////////////////////
        // OPOS "CapPowerReporting", "PowerState", "PowerNotify" Property
        //   Constants (added in 1.3)
        /////////////////////////////////////////////////////////////////////

        const long OPOS_PR_NONE = 0;
        const long OPOS_PR_STANDARD = 1;
        const long OPOS_PR_ADVANCED = 2;

        const long OPOS_PN_DISABLED = 0;
        const long OPOS_PN_ENABLED = 1;

        const long OPOS_PS_UNKNOWN = 2000;
        const long OPOS_PS_ONLINE = 2001;
        const long OPOS_PS_OFF = 2002;
        const long OPOS_PS_OFFLINE = 2003;
        const long OPOS_PS_OFF_OFFLINE = 2004;


        /////////////////////////////////////////////////////////////////////
        // "CompareFirmwareVersion" Method: "Result" Parameter Constants
        //   (added in 1.9)
        /////////////////////////////////////////////////////////////////////

        const long OPOS_CFV_FIRMWARE_OLDER = 1;
        const long OPOS_CFV_FIRMWARE_SAME = 2;
        const long OPOS_CFV_FIRMWARE_NEWER = 3;
        const long OPOS_CFV_FIRMWARE_DIFFERENT = 4;
        const long OPOS_CFV_FIRMWARE_UNKNOWN = 5;


        /////////////////////////////////////////////////////////////////////
        // "ErrorEvent" Event: "ErrorLocus" Parameter Constants
        /////////////////////////////////////////////////////////////////////

        const long OPOS_EL_OUTPUT = 1;
        const long OPOS_EL_INPUT = 2;
        const long OPOS_EL_INPUT_DATA = 3;


        /////////////////////////////////////////////////////////////////////
        // "ErrorEvent" Event: "ErrorResponse" Constants
        /////////////////////////////////////////////////////////////////////

        const long OPOS_ER_RETRY = 11;
        const long OPOS_ER_CLEAR = 12;
        const long OPOS_ER_CONTINUEINPUT = 13;


        /////////////////////////////////////////////////////////////////////
        // "StatusUpdateEvent" Event: Common "Status" Constants
        /////////////////////////////////////////////////////////////////////

        const long OPOS_SUE_POWER_ONLINE = 2001; // (added in 1.3)
        const long OPOS_SUE_POWER_OFF = 2002; // (added in 1.3)
        const long OPOS_SUE_POWER_OFFLINE = 2003; // (added in 1.3)
        const long OPOS_SUE_POWER_OFF_OFFLINE = 2004; // (added in 1.3)

        const long OPOS_SUE_UF_PROGRESS = 2100; // (added in 1.9)
        const long OPOS_SUE_UF_COMPLETE = 2200; // (added in 1.9)
        const long OPOS_SUE_UF_COMPLETE_DEV_NOT_RESTORED = 2205; // (added in 1.9)
        const long OPOS_SUE_UF_FAILED_DEV_OK = 2201; // (added in 1.9)
        const long OPOS_SUE_UF_FAILED_DEV_UNRECOVERABLE = 2202; // (added in 1.9)
        const long OPOS_SUE_UF_FAILED_DEV_NEEDS_FIRMWARE = 2203; // (added in 1.9)
        const long OPOS_SUE_UF_FAILED_DEV_UNKNOWN = 2204; // (added in 1.9)


        /////////////////////////////////////////////////////////////////////
        // General Constants
        /////////////////////////////////////////////////////////////////////

        const long OPOS_FOREVER = -1; // (added in 1.2)




        /////////////////////////////////////////////////////////////////////
        // Printer Station Constants
        /////////////////////////////////////////////////////////////////////

        const long PTR_S_JOURNAL = 1;
        const long PTR_S_RECEIPT = 2;
        const long PTR_S_SLIP = 4;

        const long PTR_S_JOURNAL_RECEIPT = 0x0003;
        const long PTR_S_JOURNAL_SLIP = 0x0005;
        const long PTR_S_RECEIPT_SLIP = 0x0006;

        const long PTR_TWO_RECEIPT_JOURNAL = 0x8003; // (added in 1.3)
        const long PTR_TWO_SLIP_JOURNAL = 0x8005; // (added in 1.3)
        const long PTR_TWO_SLIP_RECEIPT = 0x8006; // (added in 1.3)


        /////////////////////////////////////////////////////////////////////
        // "CapCharacterSet" Property Constants (added in 1.1)
        /////////////////////////////////////////////////////////////////////

        const long PTR_CCS_ALPHA = 1;
        const long PTR_CCS_ASCII = 998;
        const long PTR_CCS_KANA = 10;
        const long PTR_CCS_KANJI = 11;
        const long PTR_CCS_UNICODE = 997; // (added in 1.5)


        /////////////////////////////////////////////////////////////////////
        // "CharacterSet" Property Constants
        /////////////////////////////////////////////////////////////////////

        const long PTR_CS_UNICODE = 997; // (added in 1.5)
        const long PTR_CS_ASCII = 998;
        const long PTR_CS_WINDOWS = 999;
        const long PTR_CS_ANSI = 999;


        /////////////////////////////////////////////////////////////////////
        // "ErrorLevel" Property Constants (added in 1.1)
        /////////////////////////////////////////////////////////////////////

        const long PTR_EL_NONE = 1;
        const long PTR_EL_RECOVERABLE = 2;
        const long PTR_EL_FATAL = 3;


        /////////////////////////////////////////////////////////////////////
        // "MapMode" Property Constants
        /////////////////////////////////////////////////////////////////////

        const long PTR_MM_DOTS = 1;
        const long PTR_MM_TWIPS = 2;
        const long PTR_MM_ENGLISH = 3;
        const long PTR_MM_METRIC = 4;


        /////////////////////////////////////////////////////////////////////
        // "CapXxxColor" Property Constants
        /////////////////////////////////////////////////////////////////////

        const long PTR_COLOR_PRIMARY = 0x00000001;
        const long PTR_COLOR_CUSTOM1 = 0x00000002;
        const long PTR_COLOR_CUSTOM2 = 0x00000004;
        const long PTR_COLOR_CUSTOM3 = 0x00000008;
        const long PTR_COLOR_CUSTOM4 = 0x00000010;
        const long PTR_COLOR_CUSTOM5 = 0x00000020;
        const long PTR_COLOR_CUSTOM6 = 0x00000040;
        const long PTR_COLOR_CYAN = 0x00000100;
        const long PTR_COLOR_MAGENTA = 0x00000200;
        const long PTR_COLOR_YELLOW = 0x00000400;
        const long PTR_COLOR_FULL = 0x80000000;


        /////////////////////////////////////////////////////////////////////
        // "CapXxxCartridgeSensor" and  "XxxCartridgeState" Property Constants
        //   (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        const long PTR_CART_UNKNOWN = 0x10000000;
        const long PTR_CART_OK = 0x00000000;
        const long PTR_CART_REMOVED = 0x00000001;
        const long PTR_CART_EMPTY = 0x00000002;
        const long PTR_CART_NEAREND = 0x00000004;
        const long PTR_CART_CLEANING = 0x00000008;


        /////////////////////////////////////////////////////////////////////
        // "CartridgeNotify" Property Constants (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        const long PTR_CN_DISABLED = 0x00000000;
        const long PTR_CN_ENABLED = 0x00000001;


        /////////////////////////////////////////////////////////////////////
        // "PageModeDescriptor" Property Constants (added in 1.9)
        /////////////////////////////////////////////////////////////////////

        const long PTR_PM_BITMAP = 0x00000001;
        const long PTR_PM_BARCODE = 0x00000002;
        const long PTR_PM_BM_ROTATE = 0x00000004;
        const long PTR_PM_BC_ROTATE = 0x00000008;
        const long PTR_PM_OPAQUE = 0x00000010;


        /////////////////////////////////////////////////////////////////////
        // "PageModePrintDirection" Property Constants (added in 1.9)
        /////////////////////////////////////////////////////////////////////

        const long PTR_PD_LEFT_TO_RIGHT = 1;
        const long PTR_PD_BOTTOM_TO_TOP = 2;
        const long PTR_PD_RIGHT_TO_LEFT = 3;
        const long PTR_PD_TOP_TO_BOTTOM = 4;


        /////////////////////////////////////////////////////////////////////
        // "CutPaper" Method Constant
        /////////////////////////////////////////////////////////////////////

        const long PTR_CP_FULLCUT = 100;


        /////////////////////////////////////////////////////////////////////
        // "PageModePrint" Method: "Control" Parameter Constants (added in 1.9)
        /////////////////////////////////////////////////////////////////////

        const long PTR_PM_PAGE_MODE = 1;
        const long PTR_PM_PRINT_SAVE = 2;
        const long PTR_PM_NORMAL = 3;
        const long PTR_PM_CANCEL = 4;


        /////////////////////////////////////////////////////////////////////
        // "PrintBarCode" Method Constants:
        /////////////////////////////////////////////////////////////////////

        //** "Alignment" Parameter
        //     Either the distance from the left-most print column to the start
        //     of the bar code, or one of the following:

        const long PTR_BC_LEFT = -1;
        const long PTR_BC_CENTER = -2;
        const long PTR_BC_RIGHT = -3;

        //** "TextPosition" Parameter

        const long PTR_BC_TEXT_NONE = -11;
        const long PTR_BC_TEXT_ABOVE = -12;
        const long PTR_BC_TEXT_BELOW = -13;

        //** "Symbology" Parameter:

        //    - One dimensional symbologies
        /*const long PTR_BCS_UPCA = 101;  // Digits
        const long PTR_BCS_UPCE = 102;  // Digits
        const long PTR_BCS_JAN8 = 103;  // = EAN 8
        const long PTR_BCS_EAN8 = 103;  // = JAN 8 (added in 1.2)
        const long PTR_BCS_JAN13 = 104;  // = EAN 13
        const long PTR_BCS_EAN13 = 104;  // = JAN 13 (added in 1.2)
        const long PTR_BCS_TF = 105;  // (Discrete 2 of 5) Digits
        const long PTR_BCS_ITF = 106;  // (Interleaved 2 of 5) Digits
        const long PTR_BCS_Codabar = 107;  // Digits, -, $, :, /, ., +;
                                           //   4 start/stop characters
                                           //   (a, b, c, d)
        const long PTR_BCS_Code39 = 108;  // Alpha, Digits, Space, -, .,
                                          //   $, /, +, %; start/stop (*)
                                          // Also has Full ASCII feature
        const long PTR_BCS_Code93 = 109;  // Same characters as Code 39
        const long PTR_BCS_Code128 = 110;  // 128 data characters

        //    - One dimensional symbologies (added in 1.2)
        const long PTR_BCS_UPCA_S = 111;  // UPC-A with supplemental
                                          //   barcode
        const long PTR_BCS_UPCE_S = 112;  // UPC-E with supplemental
                                          //   barcode
        const long PTR_BCS_UPCD1 = 113;  // UPC-D1
        const long PTR_BCS_UPCD2 = 114;  // UPC-D2
        const long PTR_BCS_UPCD3 = 115;  // UPC-D3
        const long PTR_BCS_UPCD4 = 116;  // UPC-D4
        const long PTR_BCS_UPCD5 = 117;  // UPC-D5
        const long PTR_BCS_EAN8_S = 118;  // EAN 8 with supplemental
                                          //   barcode
        const long PTR_BCS_EAN13_S = 119;  // EAN 13 with supplemental
                                           //   barcode
        const long PTR_BCS_EAN128 = 120;  // EAN 128
        const long PTR_BCS_OCRA = 121;  // OCR "A"
        const long PTR_BCS_OCRB = 122;  // OCR "B"*/

        //    - One dimensional symbologies (added in 1.8)
        const long PTR_BCS_Code128_Parsed = 123;  // Code 128 with parsing
                                                  //        The following RSS constants deprecated in 1.12.
                                                  //        Instead use the GS1DATABAR constants below.
        const long PTR_BCS_RSS14 = 131;  // Reduced Space Symbology - 14 digit GTIN
        const long PTR_BCS_RSS_EXPANDED = 132;  // RSS - 14 digit GTIN plus additional fields

        //    - One dimensional symbologies (added in 1.12)
        const long PTR_BCS_GS1DATABAR = 131;  // GS1 DataBar Omnidirectional
        const long PTR_BCS_GS1DATABAR_E = 132;  // GS1 DataBar Expanded
        const long PTR_BCS_GS1DATABAR_S = 133;  // GS1 DataBar Stacked Omnidirectional
        const long PTR_BCS_GS1DATABAR_E_S = 134;  // GS1 DataBar Expanded Stacked

        //    - Two dimensional symbologies
        const long PTR_BCS_PDF417 = 201;
        const long PTR_BCS_MAXICODE = 202;

        //    - Two dimensional symbologies (added in 1.13)
        const long PTR_BCS_DATAMATRIX = 203;  // Data Matrix
        const long PTR_BCS_QRCODE = 204;  // QR Code
        const long PTR_BCS_UQRCODE = 205;  // Micro QR Code
        const long PTR_BCS_AZTEC = 206;  // Aztec
        const long PTR_BCS_UPDF417 = 207;  // Micro PDF 417

        //    - Start of Printer-Specific bar code symbologies
        const long PTR_BCS_OTHER = 501;


        /////////////////////////////////////////////////////////////////////
        // "PrintBitmap" and "PrintMemoryBitmap" Method Constants:
        /////////////////////////////////////////////////////////////////////

        //** "Width" Parameter
        //     Either bitmap width or:

        const long PTR_BM_ASIS = -11;  // One pixel per printer dot

        //** "Alignment" Parameter
        //     Either the distance from the left-most print column to the start
        //     of the bitmap, or one of the following:

        const long PTR_BM_LEFT = -1;
        const long PTR_BM_CENTER = -2;
        const long PTR_BM_RIGHT = -3;

        //** "Type" Parameter ("PrintMemoryBitmap" only)
        const long PTR_BMT_BMP = 1;
        const long PTR_BMT_JPEG = 2;
        const long PTR_BMT_GIF = 3;


        /////////////////////////////////////////////////////////////////////
        // "RotatePrint" Method: "Rotation" Parameter Constants
        // "RotateSpecial" Property Constants
        /////////////////////////////////////////////////////////////////////

        const long PTR_RP_NORMAL = 0x0001;
        const long PTR_RP_RIGHT90 = 0x0101;
        const long PTR_RP_LEFT90 = 0x0102;
        const long PTR_RP_ROTATE180 = 0x0103;

        // For "RotatePrint", one or both of the following values may be
        // ORed with one of the above values.
        const long PTR_RP_BARCODE = 0x1000; // (added in 1.7)
        const long PTR_RP_BITMAP = 0x2000; // (added in 1.7)


        /////////////////////////////////////////////////////////////////////
        // "SetLogo" Method: "Location" Parameter Constants
        /////////////////////////////////////////////////////////////////////

        const long PTR_L_TOP = 1;
        const long PTR_L_BOTTOM = 2;


        /////////////////////////////////////////////////////////////////////
        // "TransactionPrint" Method: "Control" Parameter Constants (added in 1.1)
        /////////////////////////////////////////////////////////////////////

        const long PTR_TP_TRANSACTION = 11;
        const long PTR_TP_NORMAL = 12;


        /////////////////////////////////////////////////////////////////////
        // "MarkFeed" Method: "Type" Parameter Constants (added in 1.5)
        // "CapRecMarkFeed" Property Constants (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        const long PTR_MF_TO_TAKEUP = 1;
        const long PTR_MF_TO_CUTTER = 2;
        const long PTR_MF_TO_CURRENT_TOF = 4;
        const long PTR_MF_TO_NEXT_TOF = 8;


        /////////////////////////////////////////////////////////////////////
        // "ChangePrintSide" Method: "Side" Parameter Constants (added in 1.5)
        /////////////////////////////////////////////////////////////////////

        const long PTR_PS_UNKNOWN = 0;
        const long PTR_PS_SIDE1 = 1;
        const long PTR_PS_SIDE2 = 2;
        const long PTR_PS_OPPOSITE = 3;


        /////////////////////////////////////////////////////////////////////
        // "CapRecRuledLine" and "CapSlpRuledLine" Property Constants
        // "DrawRuledLine" Method: "LineDirection" Parameter Constants
        // (added in 1.13)
        /////////////////////////////////////////////////////////////////////

        const long PTR_RL_HORIZONTAL = 1;
        const long PTR_RL_VERTICAL = 2;


        /////////////////////////////////////////////////////////////////////
        // "DrawRuledLine" Method: "LineStyle" Parameter Constants
        // (added in 1.13)
        /////////////////////////////////////////////////////////////////////

        const long PTR_LS_SINGLE_SOLID_LINE = 1;
        const long PTR_LS_DOUBLE_SOLID_LINE = 2;
        const long PTR_LS_BROKEN_LINE = 3;
        const long PTR_LS_CHAIN_LINE = 4;


        /////////////////////////////////////////////////////////////////////
        // "StatusUpdateEvent" Event: "Data" Parameter Constants
        /////////////////////////////////////////////////////////////////////

        const long PTR_SUE_COVER_OPEN = 11;
        const long PTR_SUE_COVER_OK = 12;
        const long PTR_SUE_JRN_COVER_OPEN = 60;  // (added in 1.8)
        const long PTR_SUE_JRN_COVER_OK = 61;  // (added in 1.8)
        const long PTR_SUE_REC_COVER_OPEN = 62;  // (added in 1.8)
        const long PTR_SUE_REC_COVER_OK = 63;  // (added in 1.8)
        const long PTR_SUE_SLP_COVER_OPEN = 64;  // (added in 1.8)
        const long PTR_SUE_SLP_COVER_OK = 65;  // (added in 1.8)

        const long PTR_SUE_JRN_EMPTY = 21;
        const long PTR_SUE_JRN_NEAREMPTY = 22;
        const long PTR_SUE_JRN_PAPEROK = 23;

        const long PTR_SUE_REC_EMPTY = 24;
        const long PTR_SUE_REC_NEAREMPTY = 25;
        const long PTR_SUE_REC_PAPEROK = 26;

        const long PTR_SUE_SLP_EMPTY = 27;
        const long PTR_SUE_SLP_NEAREMPTY = 28;
        const long PTR_SUE_SLP_PAPEROK = 29;

        const long PTR_SUE_JRN_CARTRIDGE_EMPTY = 41; // (added in 1.5)
        const long PTR_SUE_JRN_CARTRIDGE_NEAREMPTY = 42; // (added in 1.5)
        const long PTR_SUE_JRN_HEAD_CLEANING = 43; // (added in 1.5)
        const long PTR_SUE_JRN_CARTRIDGE_OK = 44; // (added in 1.5)

        const long PTR_SUE_REC_CARTRIDGE_EMPTY = 45; // (added in 1.5)
        const long PTR_SUE_REC_CARTRIDGE_NEAREMPTY = 46; // (added in 1.5)
        const long PTR_SUE_REC_HEAD_CLEANING = 47; // (added in 1.5)
        const long PTR_SUE_REC_CARTRIDGE_OK = 48; // (added in 1.5)

        const long PTR_SUE_SLP_CARTRIDGE_EMPTY = 49; // (added in 1.5)
        const long PTR_SUE_SLP_CARTRIDGE_NEAREMPTY = 50; // (added in 1.5)
        const long PTR_SUE_SLP_HEAD_CLEANING = 51; // (added in 1.5)
        const long PTR_SUE_SLP_CARTRIDGE_OK = 52; // (added in 1.5)

        const long PTR_SUE_IDLE = 1001;


        /////////////////////////////////////////////////////////////////////
        // "ResultCodeExtended" Property Constants
        /////////////////////////////////////////////////////////////////////

        const long OPOS_EPTR_COVER_OPEN = 201; // (Several)
        const long OPOS_EPTR_JRN_EMPTY = 202; // (Several)
        const long OPOS_EPTR_REC_EMPTY = 203; // (Several)
        const long OPOS_EPTR_SLP_EMPTY = 204; // (Several)
        const long OPOS_EPTR_SLP_FORM = 205; // EndRemoval
        const long OPOS_EPTR_TOOBIG = 206; // PrintBitmap
        const long OPOS_EPTR_BADFORMAT = 207; // PrintBitmap
        const long OPOS_EPTR_JRN_CARTRIDGE_REMOVED = 208; // (Several) (added in 1.5)
        const long OPOS_EPTR_JRN_CARTRIDGE_EMPTY = 209; // (Several) (added in 1.5)
        const long OPOS_EPTR_JRN_HEAD_CLEANING = 210; // (Several) (added in 1.5)
        const long OPOS_EPTR_REC_CARTRIDGE_REMOVED = 211; // (Several) (added in 1.5)
        const long OPOS_EPTR_REC_CARTRIDGE_EMPTY = 212; // (Several) (added in 1.5)
        const long OPOS_EPTR_REC_HEAD_CLEANING = 213; // (Several) (added in 1.5)
        const long OPOS_EPTR_SLP_CARTRIDGE_REMOVED = 214; // (Several) (added in 1.5)
        const long OPOS_EPTR_SLP_CARTRIDGE_EMPTY = 215; // (Several) (added in 1.5)
        const long OPOS_EPTR_SLP_HEAD_CLEANING = 216; // (Several) (added in 1.5)

        public static string getState(long value)
        {
            Dictionary<long, string> stateMap = new Dictionary<long, string>
            {
                {OPOS_SUCCESS ,"OPOS_SUCCESS"}     ,
                {OPOS_E_CLOSED,"OPOS_E_CLOSED"}     ,
                {OPOS_E_CLAIMED,"OPOS_E_CLAIMED"}    ,
                {OPOS_E_NOTCLAIMED ,"OPOS_E_NOTCLAIMED"},
                {OPOS_E_NOSERVICE  ,"OPOS_E_NOSERVICE"},
                {OPOS_E_DISABLED,"OPOS_E_DISABLED"}   ,
                {OPOS_E_ILLEGAL ,"OPOS_E_ILLEGAL"}   ,
                {OPOS_E_NOHARDWARE ,"OPOS_E_NOHARDWARE"},
                {OPOS_E_OFFLINE ,"OPOS_E_OFFLINE"}   ,
                {OPOS_E_NOEXIST ,"OPOS_E_NOEXIST"}   ,
                {OPOS_E_EXISTS ,"OPOS_E_EXISTS"}    ,
                {OPOS_E_FAILURE ,"OPOS_E_FAILURE"}   ,
                {OPOS_E_TIMEOUT ,"OPOS_E_TIMEOUT"}   ,
                {OPOS_E_BUSY,"OPOS_E_BUSY"}       ,
                {OPOS_E_EXTENDED,"OPOS_E_EXTENDED"}   ,
                { OPOS_E_DEPRECATED,"OPOS_E_DEPRECATED"},
            };
            if (stateMap.ContainsKey(value))
            {
                return stateMap[value];
            }
            else
            {
                return "Unknown constant";
            }

        }


    }
}
