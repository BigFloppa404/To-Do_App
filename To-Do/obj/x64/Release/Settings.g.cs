﻿#pragma checksum "E:\VS Projects\To-Do_App\To-Do\Settings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "98D02925001C3C09FF210F178DB3178B20AD579840466652D41D8FA6D3E797D2"
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
    partial class Settings : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ToolTipService_ToolTip(global::Windows.UI.Xaml.DependencyObject obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                global::Windows.UI.Xaml.Controls.ToolTipService.SetToolTip(obj, value);
            }
            public static void Set_Windows_UI_Xaml_Shapes_Shape_Fill(global::Windows.UI.Xaml.Shapes.Shape obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Fill = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Border_Background(global::Windows.UI.Xaml.Controls.Border obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Settings_obj3_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettings_Bindings
        {
            private global::To_Do.GridThemeItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj3;
            private global::Windows.UI.Xaml.Shapes.Polygon obj4;
            private global::Windows.UI.Xaml.Controls.Border obj5;
            private global::Windows.UI.Xaml.Shapes.Polygon obj6;
            private global::Windows.UI.Xaml.Shapes.Ellipse obj7;
            private global::Windows.UI.Xaml.Shapes.Polygon obj8;
            private global::Windows.UI.Xaml.Shapes.Polygon obj9;

            public Settings_obj3_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Settings.xaml line 12
                        this.obj3 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 4: // Settings.xaml line 13
                        this.obj4 = (global::Windows.UI.Xaml.Shapes.Polygon)target;
                        break;
                    case 5: // Settings.xaml line 15
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 6: // Settings.xaml line 18
                        this.obj6 = (global::Windows.UI.Xaml.Shapes.Polygon)target;
                        break;
                    case 7: // Settings.xaml line 23
                        this.obj7 = (global::Windows.UI.Xaml.Shapes.Ellipse)target;
                        break;
                    case 8: // Settings.xaml line 25
                        this.obj8 = (global::Windows.UI.Xaml.Shapes.Polygon)target;
                        break;
                    case 9: // Settings.xaml line 26
                        this.obj9 = (global::Windows.UI.Xaml.Shapes.Polygon)target;
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
                            (this.obj3.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::To_Do.GridThemeItem) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ISettings_Bindings

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
                    this.dataRoot = (global::To_Do.GridThemeItem)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::To_Do.GridThemeItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_tooltip(obj.tooltip, phase);
                        this.Update_darkThemeVariant(obj.darkThemeVariant, phase);
                        this.Update_backgroundBrush(obj.backgroundBrush, phase);
                        this.Update_borderBrush(obj.borderBrush, phase);
                    }
                }
            }
            private void Update_tooltip(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Settings.xaml line 12
                    if ((this.obj3.Target as global::Windows.UI.Xaml.Controls.Grid) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToolTipService_ToolTip((this.obj3.Target as global::Windows.UI.Xaml.Controls.Grid), obj, null);
                    }
                }
            }
            private void Update_darkThemeVariant(global::To_Do.GridThemeItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_darkThemeVariant_backgroundBrush(obj.backgroundBrush, phase);
                        this.Update_darkThemeVariant_borderBrush(obj.borderBrush, phase);
                    }
                }
            }
            private void Update_darkThemeVariant_backgroundBrush(global::Windows.UI.Xaml.Media.Brush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Settings.xaml line 13
                    XamlBindingSetters.Set_Windows_UI_Xaml_Shapes_Shape_Fill(this.obj4, obj, null);
                }
            }
            private void Update_backgroundBrush(global::Windows.UI.Xaml.Media.Brush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Settings.xaml line 15
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj5, obj, null);
                }
            }
            private void Update_borderBrush(global::Windows.UI.Xaml.Media.Brush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Settings.xaml line 18
                    XamlBindingSetters.Set_Windows_UI_Xaml_Shapes_Shape_Fill(this.obj6, obj, null);
                }
            }
            private void Update_darkThemeVariant_borderBrush(global::Windows.UI.Xaml.Media.Brush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Settings.xaml line 23
                    XamlBindingSetters.Set_Windows_UI_Xaml_Shapes_Shape_Fill(this.obj7, obj, null);
                    // Settings.xaml line 25
                    XamlBindingSetters.Set_Windows_UI_Xaml_Shapes_Shape_Fill(this.obj8, obj, null);
                    // Settings.xaml line 26
                    XamlBindingSetters.Set_Windows_UI_Xaml_Shapes_Shape_Fill(this.obj9, obj, null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Settings_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettings_Bindings
        {
            private global::To_Do.Settings dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj12;

            public Settings_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 12: // Settings.xaml line 65
                        this.obj12 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // ISettings_Bindings

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
                    this.dataRoot = (global::To_Do.Settings)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::To_Do.Settings obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_gridItems(obj.gridItems, phase);
                    }
                }
            }
            private void Update_gridItems(global::System.Collections.ObjectModel.ObservableCollection<global::To_Do.GridThemeItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Settings.xaml line 65
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj12, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 10: // Settings.xaml line 46
                {
                    this.navStyleCombo = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.navStyleCombo).SelectionChanged += this.navStyleCombo_SelectionChanged;
                }
                break;
            case 11: // Settings.xaml line 59
                {
                    this.ThemePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 12: // Settings.xaml line 65
                {
                    this.themeGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.themeGrid).ItemClick += this.themeGrid_ItemClick;
                }
                break;
            case 13: // Settings.xaml line 80
                {
                    this.RoundCornerToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.RoundCornerToggle).Toggled += this.OnRoundedCornerToggled;
                }
                break;
            case 14: // Settings.xaml line 81
                {
                    this.btntoggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.btntoggle).Toggled += this.OnBGIMGToggled;
                }
                break;
            case 15: // Settings.xaml line 82
                {
                    this.Fallbackpanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 16: // Settings.xaml line 93
                {
                    this.bgimgbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.bgimgbutton).Click += this.Chooseimg;
                }
                break;
            case 17: // Settings.xaml line 84
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.LaunchSettings;
                }
                break;
            case 19: // Settings.xaml line 60
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element19 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element19).Checked += this.OnThemeRadioButtonChecked;
                }
                break;
            case 20: // Settings.xaml line 61
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element20 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element20).Checked += this.OnThemeRadioButtonChecked;
                }
                break;
            case 21: // Settings.xaml line 62
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element21 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element21).Checked += this.OnThemeRadioButtonChecked;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Settings.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Settings_obj1_Bindings bindings = new Settings_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 3: // Settings.xaml line 12
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element3 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Settings_obj3_Bindings bindings = new Settings_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element3, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

