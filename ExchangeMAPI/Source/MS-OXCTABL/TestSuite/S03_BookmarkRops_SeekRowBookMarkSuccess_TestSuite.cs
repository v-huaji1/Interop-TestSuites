//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCTABL {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.Protocols.TestTools;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3130.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite : PtfTestClassBase {
        
        public S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "2000000");
        }
        
        #region Expect Delegates
        public delegate void CheckMAPIHTTPTransportSupportedDelegate1(bool isSupported);
        
        public delegate void RopQueryPositionResponseDelegate1(Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition cursorPosition, bool isRowCount);
        
        public delegate void RopSeekRowBookmarkResponseDelegate1(bool wantRowMovedCountout, bool enoughRow, bool hasSoughtLess, bool isActualRowsCount, bool rowNoLongerVisible);
        #endregion
        
        #region Event Metadata
        static System.Reflection.MethodBase CheckMAPIHTTPTransportSupportedInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "CheckMAPIHTTPTransportSupported", typeof(bool).MakeByRefType());
        
        static System.Reflection.EventInfo RopQueryPositionResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "RopQueryPositionResponse");
        
        static System.Reflection.EventInfo RopSeekRowBookmarkResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "RopSeekRowBookmarkResponse");
        #endregion
        
        #region Adapter Instances
        private Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter IMS_OXCTABLAdapterInstance;
        #endregion
        
        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context) {
            PtfTestClassBase.Initialize(context);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup() {
            PtfTestClassBase.Cleanup();
        }
        #endregion
        
        #region Test Initialization and Cleanup
        protected override void TestInitialize() {
            this.InitializeTestManager();
            this.IMS_OXCTABLAdapterInstance = ((Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter))));
            this.Manager.Subscribe(RopQueryPositionResponseInfo, this.IMS_OXCTABLAdapterInstance);
            this.Manager.Subscribe(RopSeekRowBookmarkResponseInfo, this.IMS_OXCTABLAdapterInstance);
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite() {
            this.Manager.BeginTest("MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite");
            this.Manager.Comment("reaching state \'S0\'");
            bool temp0;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp0);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp0);
            this.Manager.Comment("reaching state \'S1\'");
            int temp10 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteCheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteCheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp10 == 0)) {
                this.Manager.Comment("reaching state \'S4\'");
                goto label1;
            }
            if ((temp10 == 1)) {
                this.Manager.Comment("reaching state \'S5\'");
                this.Manager.Comment("executing step \'call InitializeTable(CONTENT_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType)(0)));
                this.Manager.Comment("reaching state \'S8\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S10\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp1;
                this.Manager.Comment("executing step \'call RopSetColumns(1,False,False,False)\'");
                temp1 = this.IMS_OXCTABLAdapterInstance.RopSetColumns(1u, false, false, false);
                this.Manager.Checkpoint("MS-OXCTABL_R831");
                this.Manager.Checkpoint("MS-OXCTABL_R45");
                this.Manager.Comment("reaching state \'S12\'");
                this.Manager.Comment("checking step \'return RopSetColumns/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp1, "return of RopSetColumns, state S12");
                this.Manager.Comment("reaching state \'S14\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp2;
                this.Manager.Comment("executing step \'call RopQueryPosition()\'");
                temp2 = this.IMS_OXCTABLAdapterInstance.RopQueryPosition();
                this.Manager.Checkpoint("MS-OXCTABL_R846");
                this.Manager.Comment("reaching state \'S16\'");
                this.Manager.Comment("checking step \'return RopQueryPosition/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp2, "return of RopQueryPosition, state S16");
                this.Manager.Comment("reaching state \'S18\'");
                int temp9 = this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker)), new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker1)), new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker2)));
                if ((temp9 == 0)) {
                    this.Manager.Comment("reaching state \'S20\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp3;
                    this.Manager.Comment("executing step \'call RopCreateBookmark()\'");
                    temp3 = this.IMS_OXCTABLAdapterInstance.RopCreateBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R526");
                    this.Manager.Comment("reaching state \'S24\'");
                    this.Manager.Comment("checking step \'return RopCreateBookmark/success\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp3, "return of RopCreateBookmark, state S24");
                    this.Manager.Comment("reaching state \'S28\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp4;
                    this.Manager.Comment("executing step \'call RopSeekRowBookmark(True,True,False)\'");
                    temp4 = this.IMS_OXCTABLAdapterInstance.RopSeekRowBookmark(true, true, false);
                    this.Manager.Checkpoint("MS-OXCTABL_R508");
                    this.Manager.Checkpoint("MS-OXCTABL_R504");
                    this.Manager.Checkpoint("MS-OXCTABL_R522");
                    this.Manager.Comment("reaching state \'S32\'");
                    this.Manager.Comment("checking step \'return RopSeekRowBookmark/success\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp4, "return of RopSeekRowBookmark, state S32");
                    this.Manager.Comment("reaching state \'S35\'");
                    if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopSeekRowBookmarkResponseInfo, null, new RopSeekRowBookmarkResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker))) != -1)) {
                        S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteS38();
                    }
                    else {
                        this.Manager.CheckObservationTimeout(false, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopSeekRowBookmarkResponseInfo, null, new RopSeekRowBookmarkResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker)));
                    }
                    goto label0;
                }
                if ((temp9 == 1)) {
                    this.Manager.Comment("reaching state \'S21\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp5;
                    this.Manager.Comment("executing step \'call RopCreateBookmark()\'");
                    temp5 = this.IMS_OXCTABLAdapterInstance.RopCreateBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R526");
                    this.Manager.Comment("reaching state \'S25\'");
                    this.Manager.Comment("checking step \'return RopCreateBookmark/success\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp5, "return of RopCreateBookmark, state S25");
                    this.Manager.Comment("reaching state \'S29\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp6;
                    this.Manager.Comment("executing step \'call RopSeekRowBookmark(True,True,True)\'");
                    temp6 = this.IMS_OXCTABLAdapterInstance.RopSeekRowBookmark(true, true, true);
                    this.Manager.Checkpoint("MS-OXCTABL_R508");
                    this.Manager.Checkpoint("MS-OXCTABL_R504");
                    this.Manager.Checkpoint("MS-OXCTABL_R522");
                    this.Manager.Comment("reaching state \'S33\'");
                    this.Manager.Comment("checking step \'return RopSeekRowBookmark/success\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp6, "return of RopSeekRowBookmark, state S33");
                    this.Manager.Comment("reaching state \'S36\'");
                    if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopSeekRowBookmarkResponseInfo, null, new RopSeekRowBookmarkResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker1))) != -1)) {
                        S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteS38();
                    }
                    else {
                        this.Manager.CheckObservationTimeout(false, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopSeekRowBookmarkResponseInfo, null, new RopSeekRowBookmarkResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker1)));
                    }
                    goto label0;
                }
                if ((temp9 == 2)) {
                    this.Manager.Comment("reaching state \'S22\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp7;
                    this.Manager.Comment("executing step \'call RopCreateBookmark()\'");
                    temp7 = this.IMS_OXCTABLAdapterInstance.RopCreateBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R526");
                    this.Manager.Comment("reaching state \'S26\'");
                    this.Manager.Comment("checking step \'return RopCreateBookmark/success\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp7, "return of RopCreateBookmark, state S26");
                    this.Manager.Comment("reaching state \'S30\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp8;
                    this.Manager.Comment("executing step \'call RopSeekRowBookmark(False,True,False)\'");
                    temp8 = this.IMS_OXCTABLAdapterInstance.RopSeekRowBookmark(false, true, false);
                    this.Manager.Checkpoint("MS-OXCTABL_R508");
                    this.Manager.Checkpoint("MS-OXCTABL_R504");
                    this.Manager.Checkpoint("MS-OXCTABL_R522");
                    this.Manager.Comment("reaching state \'S34\'");
                    this.Manager.Comment("checking step \'return RopSeekRowBookmark/success\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp8, "return of RopSeekRowBookmark, state S34");
                    this.Manager.Comment("reaching state \'S37\'");
                    if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopSeekRowBookmarkResponseInfo, null, new RopSeekRowBookmarkResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker2))) != -1)) {
                        S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteS38();
                    }
                    else {
                        this.Manager.CheckObservationTimeout(false, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopSeekRowBookmarkResponseInfo, null, new RopSeekRowBookmarkResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker2)));
                    }
                    goto label0;
                }
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker)), new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker1)), new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopQueryPositionResponseInfo, null, new RopQueryPositionResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker2)));
            label0:
;
                goto label1;
            }
            throw new InvalidOperationException("never reached");
        label1:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteCheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteCheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker(Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition cursorPosition, bool isRowCount) {
            this.Manager.Comment("checking step \'event RopQueryPositionResponse(END,True)\'");
            try {
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition)(1)), cursorPosition, "cursorPosition of RopQueryPositionResponse, state S18");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRowCount, "isRowCount of RopQueryPositionResponse, state S18");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R491");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R491");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker(bool wantRowMovedCountout, bool enoughRow, bool hasSoughtLess, bool isActualRowsCount, bool rowNoLongerVisible) {
            this.Manager.Comment("checking step \'event RopSeekRowBookmarkResponse(True,False,True,True,False)\'");
            try {
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, wantRowMovedCountout, "wantRowMovedCountout of RopSeekRowBookmarkResponse, state S35");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, enoughRow, "enoughRow of RopSeekRowBookmarkResponse, state S35");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, hasSoughtLess, "hasSoughtLess of RopSeekRowBookmarkResponse, state S35");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isActualRowsCount, "isActualRowsCount of RopSeekRowBookmarkResponse, state S35");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, rowNoLongerVisible, "rowNoLongerVisible of RopSeekRowBookmarkResponse, state S35");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R180, MS-OXCTABL_R187, MS-OXCTABL_R183");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R180");
            this.Manager.Checkpoint("MS-OXCTABL_R187");
            this.Manager.Checkpoint("MS-OXCTABL_R183");
        }
        
        private void S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteS38() {
            this.Manager.Comment("reaching state \'S38\'");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker1(Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition cursorPosition, bool isRowCount) {
            this.Manager.Comment("checking step \'event RopQueryPositionResponse(CURRENT,True)\'");
            try {
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition.CURRENT, cursorPosition, "cursorPosition of RopQueryPositionResponse, state S18");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRowCount, "isRowCount of RopQueryPositionResponse, state S18");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R491");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R491");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker1(bool wantRowMovedCountout, bool enoughRow, bool hasSoughtLess, bool isActualRowsCount, bool rowNoLongerVisible) {
            this.Manager.Comment("checking step \'event RopSeekRowBookmarkResponse(True,True,False,True,False)\'");
            try {
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, wantRowMovedCountout, "wantRowMovedCountout of RopSeekRowBookmarkResponse, state S36");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, enoughRow, "enoughRow of RopSeekRowBookmarkResponse, state S36");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, hasSoughtLess, "hasSoughtLess of RopSeekRowBookmarkResponse, state S36");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isActualRowsCount, "isActualRowsCount of RopSeekRowBookmarkResponse, state S36");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, rowNoLongerVisible, "rowNoLongerVisible of RopSeekRowBookmarkResponse, state S36");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R178, MS-OXCTABL_R503, MS-OXCTABL_R188, M" +
                        "S-OXCTABL_R166, MS-OXCTABL_R190, MS-OXCTABL_R183");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R178");
            this.Manager.Checkpoint("MS-OXCTABL_R503");
            this.Manager.Checkpoint("MS-OXCTABL_R188");
            this.Manager.Checkpoint("MS-OXCTABL_R166");
            this.Manager.Checkpoint("MS-OXCTABL_R190");
            this.Manager.Checkpoint("MS-OXCTABL_R183");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopQueryPositionResponseChecker2(Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition cursorPosition, bool isRowCount) {
            this.Manager.Comment("checking step \'event RopQueryPositionResponse(BEGIN,True)\'");
            try {
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.CursorPosition)(0)), cursorPosition, "cursorPosition of RopQueryPositionResponse, state S18");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRowCount, "isRowCount of RopQueryPositionResponse, state S18");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R491");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R491");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuiteRopSeekRowBookmarkResponseChecker2(bool wantRowMovedCountout, bool enoughRow, bool hasSoughtLess, bool isActualRowsCount, bool rowNoLongerVisible) {
            this.Manager.Comment("checking step \'event RopSeekRowBookmarkResponse(True,False,True,True,False)\'");
            try {
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, wantRowMovedCountout, "wantRowMovedCountout of RopSeekRowBookmarkResponse, state S37");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, enoughRow, "enoughRow of RopSeekRowBookmarkResponse, state S37");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, hasSoughtLess, "hasSoughtLess of RopSeekRowBookmarkResponse, state S37");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isActualRowsCount, "isActualRowsCount of RopSeekRowBookmarkResponse, state S37");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, rowNoLongerVisible, "rowNoLongerVisible of RopSeekRowBookmarkResponse, state S37");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R180, MS-OXCTABL_R187, MS-OXCTABL_R183");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R180");
            this.Manager.Checkpoint("MS-OXCTABL_R187");
            this.Manager.Checkpoint("MS-OXCTABL_R183");
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1() {
            this.Manager.BeginTest("MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1");
            this.Manager.Comment("reaching state \'S2\'");
            bool temp11;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp11);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp11);
            this.Manager.Comment("reaching state \'S3\'");
            int temp15 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1CheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1CheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp15 == 0)) {
                this.Manager.Comment("reaching state \'S6\'");
                this.Manager.Comment("executing step \'call InitializeTable(HIERARCHY_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType)(1)));
                this.Manager.Comment("reaching state \'S9\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S11\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp12;
                this.Manager.Comment("executing step \'call RopSetColumns(1,False,False,False)\'");
                temp12 = this.IMS_OXCTABLAdapterInstance.RopSetColumns(1u, false, false, false);
                this.Manager.Checkpoint("MS-OXCTABL_R829");
                this.Manager.Checkpoint("MS-OXCTABL_R45");
                this.Manager.Comment("reaching state \'S13\'");
                this.Manager.Comment("checking step \'return RopSetColumns/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp12, "return of RopSetColumns, state S13");
                this.Manager.Comment("reaching state \'S15\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp13;
                this.Manager.Comment("executing step \'call RopCreateBookmark()\'");
                temp13 = this.IMS_OXCTABLAdapterInstance.RopCreateBookmark();
                this.Manager.Checkpoint("MS-OXCTABL_R857");
                this.Manager.Comment("reaching state \'S17\'");
                this.Manager.Comment("checking step \'return RopCreateBookmark/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp13, "return of RopCreateBookmark, state S17");
                this.Manager.Comment("reaching state \'S19\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp14;
                this.Manager.Comment("executing step \'call RopSeekRowBookmark(True,True,True)\'");
                temp14 = this.IMS_OXCTABLAdapterInstance.RopSeekRowBookmark(true, true, true);
                this.Manager.Checkpoint("MS-OXCTABL_R852");
                this.Manager.Checkpoint("MS-OXCTABL_R504");
                this.Manager.Checkpoint("MS-OXCTABL_R522");
                this.Manager.Comment("reaching state \'S23\'");
                this.Manager.Comment("checking step \'return RopSeekRowBookmark/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp14, "return of RopSeekRowBookmark, state S23");
                this.Manager.Comment("reaching state \'S27\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopSeekRowBookmarkResponseInfo, null, new RopSeekRowBookmarkResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1RopSeekRowBookmarkResponseChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S31\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite.RopSeekRowBookmarkResponseInfo, null, new RopSeekRowBookmarkResponseDelegate1(this.MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1RopSeekRowBookmarkResponseChecker)));
                }
                goto label2;
            }
            if ((temp15 == 1)) {
                this.Manager.Comment("reaching state \'S7\'");
                goto label2;
            }
            throw new InvalidOperationException("never reached");
        label2:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1CheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S3");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1RopSeekRowBookmarkResponseChecker(bool wantRowMovedCountout, bool enoughRow, bool hasSoughtLess, bool isActualRowsCount, bool rowNoLongerVisible) {
            this.Manager.Comment("checking step \'event RopSeekRowBookmarkResponse(True,True,False,True,False)\'");
            try {
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, wantRowMovedCountout, "wantRowMovedCountout of RopSeekRowBookmarkResponse, state S27");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, enoughRow, "enoughRow of RopSeekRowBookmarkResponse, state S27");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, hasSoughtLess, "hasSoughtLess of RopSeekRowBookmarkResponse, state S27");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isActualRowsCount, "isActualRowsCount of RopSeekRowBookmarkResponse, state S27");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, rowNoLongerVisible, "rowNoLongerVisible of RopSeekRowBookmarkResponse, state S27");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-OXCTABL_R178, MS-OXCTABL_R503, MS-OXCTABL_R188, M" +
                        "S-OXCTABL_R166, MS-OXCTABL_R190, MS-OXCTABL_R183");
                throw;
            }
            this.Manager.Checkpoint("MS-OXCTABL_R178");
            this.Manager.Checkpoint("MS-OXCTABL_R503");
            this.Manager.Checkpoint("MS-OXCTABL_R188");
            this.Manager.Checkpoint("MS-OXCTABL_R166");
            this.Manager.Checkpoint("MS-OXCTABL_R190");
            this.Manager.Checkpoint("MS-OXCTABL_R183");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_SeekRowBookMarkSuccess_TestSuite1CheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S3");
        }
        #endregion
    }
}