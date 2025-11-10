#Bubble Sort
array=[8,20,9,17,45,7,24,62,91,100]
length=len(array)
print("unsorted Array = ",array)
print("Length         = ",length)

for i in range(0,length):
    for j in range(i+1,length):
        if array[i]>array[j]:
            temp=array[i]
            array[i]=array[j]
            array[j]=temp

print("sorted Array = ",array)
