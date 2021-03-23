using System;
using System.Collections.Generic;
using System.Text;

namespace myDictonary
{
    class myDic<TNum , TUser >
    {
        TNum[] num;
        TUser[] user;

        public myDic()
        {
            num = new TNum[0];
            user = new TUser[0];
        }

        public void Add(TNum no , TUser name)
        {
            TNum[] tempNum = num;
            TUser[] tempUser = user;

            num = new TNum[num.Length + 1];
            user = new TUser[user.Length + 1];

            for (int i = 0; i < tempNum.Length; i++)
            {
                num[i] = tempNum[i];
                user[i] = tempUser[i];

            }

            num[num.Length - 1] = no;
            user[user.Length - 1] = name;

        }
                 
        public void List()
        {
            for (int i = 0; i < user.Length; i++)
            {
                Console.WriteLine("Number : " + num[i] + " " + "Name :" + user[i]);
            }
        }

        
    }
}
