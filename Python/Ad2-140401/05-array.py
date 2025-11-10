a=[1,2,3,7,8,10]

for item in a:
    print(item)

for i in range(0,len(a)-1):
    a[i]=a[i]+a[i+1]
print(a)