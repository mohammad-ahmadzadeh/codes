x=7
array=[8,20,9,17,45,7,24,62,91,100]
#Linear Search
def lineaSearch(x:int|float,array)->int|None:
    b=-1
    for i in range(0,len(array)):
        if x==array[i]:
            b=i
    return b

#main
print("x     = ",x)
print("Array = ",array)
r=lineaSearch(x,array)
print("Result= ",r)
