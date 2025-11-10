#Bubble Sort
class BubbleSort:

    #Constructor Method(Initialization)
    def __init__(self,array):
        self.array=array
        self.length=len(array)
    
    def __str__(self):
        print("Bubble Sort")
  
    def sort(self):
        for i in range(0,self.length):
            for j in range(i+1,self.length):
                if self.array[i]>self.array[j]:
                    temp=self.array[i]
                    self.array[i]=self.array[j]
                    self.array[j]=temp
        return self.array


#main
array=[8,20,9,17,45,7,24,62,91,100]
print("unsorted Array = ",array)

bubble=BubbleSort(array)
bubble.__str__()
result=bubble.sort()
print("sorted Array   = ",result)
