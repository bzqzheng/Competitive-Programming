﻿using System;
using System.Text;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Math;
/*
	Leave the sleep and let the springtime talk
	In tongues from the time before man
	Listen to a daffodil tell her tale
	Let the guest in, walk out, be the first to greet the morn
	The meadows of heaven await harvest
	The cliffs unjumped, cold waters untouched
	The elsewhere creatures yet unseen
	Finally your number came up, free fall awaits the brave
	Come
	Taste the wine, race the blind
	They will guide you from the light
	Writing noughts till the end of time
	Come
	Surf the clouds, race the dark
	It feeds from the runs undone
	Meet me where the cliff greets the sea
*/
namespace myCSharpTemplate
{
	class MainClass
	{
		//Listen, I haven't test them all, but I think they are good enough.
		//by Yuwono Bangun Nagoro a.k.a SurgicalSteel
		const Double PI = 3.1415926535897932384626433832795;
		const int MOD = 1000000007;
		struct point{public int x; public int y;};
		static int getsinglenum(string a)//converts a single string into decimal ASCII
		{
			byte[] dec = Encoding.ASCII.GetBytes(a);
			return (int) dec[0];
		}
		static List<int> getallnum(string s)//converts whole string into decimal ASCII
		{
			var dec = Encoding.ASCII.GetBytes (s).ToList();
			List<int> li = new List<int> ();
			foreach (var i in dec) 
			{li.Add ((int)i);}
			return li;
		}
		static bool isprime(int a) //this prime test function was originally authored by Egor Suvorov a.k.a yeputons and was written in C++
		{ 
            		for (int i = 2; i * i <= a; i++)
            		{
                		if (a % i == 0)
                		{return false;}
            		}
			return true;
		}
		static string eliminateAt(string x, int num)//eliminates a single substring of a string in a given position
		{
			if(num==0){return x.Substring(1,x.Length-1);}
			else if(num==x.Length-1){return x.Substring(0,x.Length-1);}
			else{return x.Substring(0,num)+x.Substring(num+1,x.Length-1);}
		}
		static string getstr(int a)//converts a decimal ASCII into a single string
		{
			char c = Convert.ToChar(a);
			return c.ToString ();
		}
		static long pangkatp(int mybase,int exp) //powers base by exponent
		{
			if(exp==0){return 1;}
			else{return mybase*pangkatp(mybase,exp-1);}
		}
		static long factorial(int num)//finds factorial of given integer
		{
			if (num == 0) {return 1;} 
			else {return num * factorial (num - 1);}
		}
		static int sumdigit(string a) //sums all digit on given string (if the string only contains digits)
		{
			int sum=0;
			for(int x=0;x<a.Length;x++)
			{
				int tmp;
				int.TryParse (a.Substring (x, 1), out tmp);
				sum+=tmp;
			}
			return sum;
		}
		static string revstring(string s)
		{
			string build = "";
			for (int i = s.Length - 1; i >= 0; i++) 
			{build += s.Substring (i, 1);}
			return build;
		}
        	static string tobase(int num,int mybase) //translates bitmask from decimal number to base n. 2<=n<=9
       	 	{
            		string a="";
            		while(num>0)
           		{
                		a+=(num%mybase).ToString();
                		num=(num-(num%mybase))/mybase;
            		}
            		return revstring(a);
        	}
		static List<int> sieve(int n)
		{
			List<int> res=new List<int>();
			int temp=1;
			for(int i=2;i<=n;i++)
			{
				for(int a=2;a<=i;a++)
				{if(i%a==0){temp++;}}
				if(temp==2){res.Add(i);}
				temp=1;
			}
			return res;
		}
		static int binarysearch(int[] a, int val) //requires a sorted vector, will return -1 if there's no such element exists in the vector
	        {
	            if (a.Length == 0) { return -1; }
	            int l = 0;
	            int r = a.Length - 1;
	            while (l < r)
	            {
	                int m = (l + r) / 2;
	                if (a[m] > val)
	                {
	                	if(m==r){m--;}
	                	r = m;
	                }
	                if (a[m] < val)
	                {
	                	if(m==l){m++;}
	                	l = m;
	                }
	                if(a[m]==val) { return m; }//return the index
	            }
	            return -1;
	        }
		public static void Main (string[] args)
		{
			//string tmp;
			//int tc;
			//tmp = int.Parse(Console.ReadLine ());
			//int.TryParse (tmp, out tc);
			Console.WriteLine("Hello World!");

			Console.ReadLine();
		}
	}
}
