namespace OOP3._2
{
    class ProjectManager 
    {
       
        public void ekle(IPersonManager personManager)
        {
            personManager.Add();
            
           
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();


        }
    }
}
