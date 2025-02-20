namespace MyStarShop.Helpers
{
   
    public static class AllOpenForms
    {
       public static List<Form> myOpenForms = new List<Form>();
        public static void AddForm(Form frm)
        {
            
            myOpenForms.Add(frm);
        }

        public static void openFormCheck()
        {
            List<Form> checkList=new List<Form>();
            foreach (var item in myOpenForms)
            {
                if (!item.IsHandleCreated && !item.Visible)
                {
                    checkList.Add(item);
                }
            }
            for (int i = 0; i < checkList.Count; i++)
            {
                myOpenForms.Remove(checkList[i]);
            }
        }
    }
}