﻿#pragma checksum "E:\VS Projects\To-Do_App\To-Do\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E9260D4A5A7B3CF0A939B37F0005B887BEF43DD813C0C6CF8364790AFFD382CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace To_Do
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(global::Windows.UI.Xaml.Controls.FontIcon obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Glyph = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj110_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::To_Do.QueryFormat dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj110;
            private global::Windows.UI.Xaml.Controls.FontIcon obj111;
            private global::Windows.UI.Xaml.Controls.TextBlock obj112;
            private global::Windows.UI.Xaml.Controls.TextBlock obj113;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj111GlyphDisabled = false;
            private static bool isobj112TextDisabled = false;
            private static bool isobj113TextDisabled = false;

            public MainPage_obj110_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 23 && columnNumber == 87)
                {
                    isobj111GlyphDisabled = true;
                }
                else if (lineNumber == 24 && columnNumber == 122)
                {
                    isobj112TextDisabled = true;
                }
                else if (lineNumber == 28 && columnNumber == 79)
                {
                    isobj113TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 110: // MainPage.xaml line 14
                        this.obj110 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 111: // MainPage.xaml line 23
                        this.obj111 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    case 112: // MainPage.xaml line 24
                        this.obj112 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 113: // MainPage.xaml line 28
                        this.obj113 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj110.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::To_Do.QueryFormat) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::To_Do.QueryFormat)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::To_Do.QueryFormat obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_glyph(obj.glyph, phase);
                        this.Update_Title(obj.Title, phase);
                        this.Update_location(obj.location, phase);
                    }
                }
            }
            private void Update_glyph(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 23
                    if (!isobj111GlyphDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(this.obj111, obj, null);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 24
                    if (!isobj112TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj112, obj, null);
                    }
                }
            }
            private void Update_location(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 28
                    if (!isobj113TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj113, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 114: // MainPage.xaml line 504
                {
                    this.AppTitleBar = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 115: // MainPage.xaml line 506
                {
                    this.searchBoxGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 116: // MainPage.xaml line 509
                {
                    this.nview = (global::Microsoft.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.nview).DisplayModeChanged += this.nview_DisplayModeChanged;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.nview).SelectionChanged += this.NavigationView_SelectionChanged;
                }
                break;
            case 117: // MainPage.xaml line 553
                {
                    this.change = (global::Microsoft.UI.Xaml.Controls.InfoBar)(target);
                }
                break;
            case 118: // MainPage.xaml line 528
                {
                    this.inf = (global::Microsoft.UI.Xaml.Controls.InfoBadge)(target);
                }
                break;
            case 119: // MainPage.xaml line 516
                {
                    this.myDayinf = (global::Microsoft.UI.Xaml.Controls.InfoBadge)(target);
                }
                break;
            case 120: // MainPage.xaml line 544
                {
                    this.bgIMG = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 121: // MainPage.xaml line 545
                {
                    this.acrylic = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 122: // MainPage.xaml line 546
                {
                    this.acrylictint = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 123: // MainPage.xaml line 547
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 124: // MainPage.xaml line 548
                {
                    this.LoadingUI = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 125: // MainPage.xaml line 507
                {
                    global::Windows.UI.Xaml.Controls.AutoSuggestBox element125 = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)element125).SuggestionChosen += this.AutoSuggestBox_SuggestionChosen;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)element125).TextChanged += this.AutoSuggestBox_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)element125).QuerySubmitted += this.AutoSuggestBox_QuerySubmitted;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 110: // MainPage.xaml line 14
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element110 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj110_Bindings bindings = new MainPage_obj110_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element110.DataContext);
                    element110.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element110, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element110, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

