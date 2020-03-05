<Query Kind="Program" />

//Merge 2 sorted arrays into a new one

void Main()
{
	int[] Array1 = { 3, 4, 6, 10, 11, 15 };
    int[] Array2 = { 1, 5, 8, 12, 14, 19 };
	
	int[] merged = mergeArr(Array1,Array2);
	merged.Dump();
}

public int[] mergeArr(int[] a1, int[] a2)
{
	int[] newA = new int[a1.Length + a2.Length];
	
	int i=0; int j= 0; int k= 0;
	
	while(i+j < newA.Length)
	{
		if(i > a1.Length-1) {
		   if(j<= a2.Length-1){
		     newA[k] = a2[j];
			 j++;
			 k++;
			 continue;
		   }
		   else break;
		}
		else if(j> a2.Length-1){
		    if(i<= a1.Length-1){
			 newA[k] = a1[i];
			 i++;
			 k++;
			 continue;
			}
			else break;
		}
		
		if(a1[i] < a2[j]){
			newA[k] = a1[i];
			i++;
		}
		else{
			newA[k] = a2[j];
			j++;
		}
		
		k++;
	}
	
	return newA;
}