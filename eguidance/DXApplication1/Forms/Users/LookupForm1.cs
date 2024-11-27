using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.ExpressApp.Win.Utils;
using DevExpress.Utils;

namespace eguidanceV2.Forms.Users
{
    public partial class LookupForm1 : XtraFormTemplateBase, ILookupPopupFrameTemplateEx, ISeparatorsHolder, IViewHolder
    {
        private const int minWidth = 420;
        private const int minHeight = 150;
        private LookupControlTemplate frameTemplate;
        private void ButtonsContainersPanel_Changed(object sender, EventArgs e)
        {
            frameTemplate.ButtonsContainersPanel.MaximumSize = new Size(0, frameTemplate.ButtonsContainersPanel.Root.MinSize.Height);
        }
        private void UpdateMinimumSize()
        {
            int nonClientWidth = Size.Width - ClientSize.Width + Padding.Size.Width;
            int nonClientHeight = Size.Height - ClientSize.Height + Padding.Size.Height;

            Size scaledTemplateMinimumSize = ScaleUtils.GetScaleSize(frameTemplate.MinimumSize);
            Size scaledDefaultMinimumSize = ScaleUtils.GetScaleSize(new Size(minWidth, minHeight));
            MinimumSize = new Size(
                Math.Max(scaledTemplateMinimumSize.Width + nonClientWidth, scaledDefaultMinimumSize.Width),
                Math.Max(scaledTemplateMinimumSize.Height + nonClientHeight, scaledDefaultMinimumSize.Height));
        }
        private void OnSearchEnabledChanged(object sender, EventArgs e)
        {
            if (SearchEnabledChanged != null)
            {
                SearchEnabledChanged(this, new EventArgs());
            }
        }
        protected override IModelFormState GetFormStateNode()
        {
            if (View != null)
            {
                return TemplatesHelper.GetFormStateNode(View.Id);
            }
            else
            {
                return base.GetFormStateNode();
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (frameTemplate.IsSearchEnabled)
            {
                frameTemplate.FindEditor.Focus();
            }
            UpdateMinimumSize();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                frameTemplate.ButtonsContainersPanel.Changed -= new EventHandler(ButtonsContainersPanel_Changed);
                frameTemplate.SearchEnabledChanged -= OnSearchEnabledChanged;
            }
            base.Dispose(disposing);
        }
        protected override DevExpress.XtraBars.Ribbon.RibbonFormStyle RibbonFormStyle
        {
            get
            {
                return DevExpress.XtraBars.Ribbon.RibbonFormStyle.Standard;
            }
        }
        public override void SetSettings(IModelTemplate modelTemplate)
        {
            base.SetSettings(modelTemplate);
            formStateModelSynchronizerComponent.Model = GetFormStateNode();
        }
        public LookupForm1()
        {
            InitializeComponent();
            MinimumSize = ScaleUtils.GetScaleSize(new Size(minWidth, minHeight));
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            NativeMethods.SetExecutingApplicationIcon(this);
            ShowInTaskbar = true;
            KeyPreview = true;
            frameTemplate = new LookupControlTemplate();
            Controls.Add(frameTemplate);
            frameTemplate.Dock = DockStyle.Fill;
            actionsContainersManager.ActionContainerComponents.AddRange(frameTemplate.GetContainers());
            actionsContainersManager.DefaultContainer = frameTemplate.DefaultContainer;
            viewSiteManager.ViewSiteControl = (Control)frameTemplate.ViewSiteControl;
            Padding scaledButtonsContainerPadding = ScaleUtils.ScalePadding(new Padding(0, 12, 12, 0), ScaleUtils.ScaleFactor);
            frameTemplate.ButtonsContainersPanel.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(scaledButtonsContainerPadding.Left, scaledButtonsContainerPadding.Right, scaledButtonsContainerPadding.Top, scaledButtonsContainerPadding.Bottom);
            ((Control)this).Padding = ScaleUtils.ScalePadding(new Padding(0, 0, 0, 12), ScaleUtils.ScaleFactor);
            frameTemplate.ButtonsContainersPanel.Changed += new EventHandler(ButtonsContainersPanel_Changed);
            frameTemplate.SearchEnabledChanged += OnSearchEnabledChanged;
            frameTemplate.ButtonsContainersPanel.SendToBack();
            frameTemplate.ViewChanged += (s, e) =>
            {
                proxyViewChanged?.Invoke(s, e);
            };
        }
        public override void SetView(DevExpress.ExpressApp.View view)
        {
            bool isPreviuosViewNotNull = frameTemplate.ListView != null;
            frameTemplate.SetView(view);
            if (view != null)
            {
                SetFormIcon(view);
            }
            bool isT533962case = isPreviuosViewNotNull || this.WindowState == FormWindowState.Maximized;
            if (!isT533962case)
            {
                ClientSize = ScaleUtils.GetScaleSize(frameTemplate.PreferredSize);
            }
        }
        public LookupControlTemplate FrameTemplate { get { return frameTemplate; } }

        DevExpress.ExpressApp.View IViewHolder.View { get { return frameTemplate.ListView; } }
        event EventHandler<TemplateViewChangedEventArgs> proxyViewChanged;
        event EventHandler<TemplateViewChangedEventArgs> ISupportViewChanged.ViewChanged
        {
            add { proxyViewChanged += value; }
            remove { proxyViewChanged -= value; }
        }

        #region ISeparatorsHolder Members
        AnchorStyles ISeparatorsHolder.SeparatorAnchors
        {
            get
            {
                return topSeparatorControl.Visible ? AnchorStyles.Top : AnchorStyles.None;
            }
            set
            {
                topSeparatorControl.Visible = value.HasFlag(AnchorStyles.Top);
            }
        }
        #endregion

        #region ILookupPopupFrameTemplate Members
        public void SetStartSearchString(string searchString)
        {
            frameTemplate.SetStartSearchString(searchString);
        }
        public bool IsSearchEnabled
        {
            get { return frameTemplate.IsSearchEnabled; }
            set { frameTemplate.IsSearchEnabled = value; }
        }
        public void FocusFindEditor() { }
        public event EventHandler<EventArgs> SearchEnabledChanged;
        #endregion

        private void LookupForm1_Load(object sender, EventArgs e)
        {

        }
    }
}