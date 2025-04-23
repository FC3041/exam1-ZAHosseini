using System.Runtime.CompilerServices;
using System.Runtime.Remoting;

namespace Exam1;

public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        int a=0;
        
        if(x==null){
            a=-1;
        }
         if(y==null){
            a=1;
        }
        if(x==null && y==null){
            a=0;
        }
        if(x!=null && y!=null){
            x.Length.CompareTo(y.Length);
            if(x.Length.CompareTo(y.Length)==0){
            a=x.CompareTo(y);
            }
            else{
                a=x.Length.CompareTo(y.Length);
            }

        }
        return a;
        
        
        

    }
}

public class Q8ComparableString
{
    private string v;

    public Q8ComparableString(string v)
    {
        this.v = v;
    }
    public static bool operator<(Q8ComparableString a,Q8ComparableString b){
        if(a.v!=null && b.v!=null){
            return a.v.CompareTo(b.v)<0;
        }
        if(a.v==null && b.v!=null){
            return true;
        }
        return false;
        

    }
     public static bool operator>(Q8ComparableString a,Q8ComparableString b){
         if(a.v!=null && b.v!=null){
            return !(a<b);
         }
          if(a.v!=null && b.v==null){
            return true;
        }
        return false;
        

    }
    public static bool operator==(Q8ComparableString a,Q8ComparableString b){
      if(a.v==b.v || (a.v==null && b.v==null)){
        return true;
      }
        return false;
        
    }
    public static bool operator!=(Q8ComparableString a,Q8ComparableString b){
         if(a.v!=b.v || (a.v==null && b.v!=null) || (a.v!=null && b.v==null)){
        return true;
      }
        return false;
        
    }
}