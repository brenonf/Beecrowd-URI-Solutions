n = int(input())
kg = 0
custo = 0.0
for i in range(n):
    
    valor = float(input())
    compra = input().split()
    kg += len(compra)
    custo += valor
    print(f"day {i+1}: {len(compra)} kg")



kg = kg / n
custo = custo / n



print(f"{kg:.2f} kg by day")
print(f"R$ {custo:.2f} by day")
