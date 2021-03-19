using System;
using EasyTabs;
namespace Browser_System32_Beta
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            TabRenderer = new ChromeTabRenderer(this);
        }


        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = "New Tab"
                }
            };
        }
        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
