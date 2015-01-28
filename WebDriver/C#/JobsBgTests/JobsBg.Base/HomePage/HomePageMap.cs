namespace JobsBg.Base.HomePage
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class HomePageMap
    {
        private const string LinkPathFormat = "//*[@id=\"search_frm\"]/table/tbody/tr[{0}]/td/a";

        [FindsBy(How = How.XPath, Using = "/html/body/table[1]/tbody/tr/td[1]/a/img")]
        public IWebElement JobsLogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"search_frm\"]/table/tbody/tr[1]/td/a")]
        public IWebElement LocationsLink { get; set; }

        [FindsBy(How = How.Id, Using = "location_tr")]
        public IWebElement Locations { get; set; }

        [FindsBy(How = How.Id, Using = "location_cnt")]
        public IWebElement LocationCount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"location_tr\"]/div[1]/span[2]/input")]
        public IWebElement SofiaCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "categories_cnt")]
        public IWebElement CategoryCount { get; set; }

        [FindsBy(How = How.XPath, Using = string.Format(LinkPathFormat, 2))]
        public IWebElement CategoriesLink { get; set; }

        [FindsBy(How = How.Id, Using = "categories_tr")]
        public IWebElement Categories { get; set; }

        [FindsBy(How = How.Id, Using = "type_cnt")]
        public IWebElement TypesCount { get; set; }

        [FindsBy(How = How.XPath, Using = string.Format(LinkPathFormat, 3))]
        public IWebElement TypesLink { get; set; }

        [FindsBy(How = How.Id, Using = "type_tr")]
        public IWebElement Types { get; set; }

        [FindsBy(How = How.Id, Using = "position_level_cnt")]
        public IWebElement PositionLevelCount { get; set; }

        [FindsBy(How = How.XPath, Using = string.Format(LinkPathFormat, 4))]
        public IWebElement PositionLevelLink { get; set; }

        [FindsBy(How = How.Id, Using = "position_level_tr")]
        public IWebElement PositionLevel { get; set; }

        [FindsBy(How = How.Id, Using = "company_type_cnt")]
        public IWebElement CompanyTypeCount { get; set; }

        [FindsBy(How = How.XPath, Using = string.Format(LinkPathFormat, 5))]
        public IWebElement CompanyTypeLink { get; set; }

        [FindsBy(How = How.Id, Using = "company_type_tr")]
        public IWebElement CompanyType { get; set; }

        [FindsBy(How = How.Id, Using = "keywords_cnt")]
        public IWebElement KeywordsCount { get; set; }

        [FindsBy(How = How.XPath, Using = string.Format(LinkPathFormat, 6))]
        public IWebElement KeywordsLink { get; set; }

        [FindsBy(How = How.Name, Using = "keyword")]
        public IWebElement Keywords { get; set; }
    }
}
