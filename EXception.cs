using System;
namespace learn
{
    class EXception : ApplicationException
    {
        public EXception()
        {

        }
        public EXception(string messeger) : base(messeger)
        {

        }
        public void Validate(List<string> userName)
        {
            string name = "Le Khac N";
            userName.Add("Le Khac Ninh");
            userName.Add("Le Khac Nam");
            foreach (var item in userName)
            {
                if (name != item)
                {
                    throw new EXception("Tai khoan khong dung ");
                }
                else
                {
                    break;
                }
            }
        }
    }
}