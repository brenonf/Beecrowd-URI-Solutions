while True:
    try:
        n= input()
        if n == 'esquerda':
            print('ingles')
        if n == 'direita':
            print('frances')
        if n == 'nenhuma':
            print('portugues')
        if n == 'as duas':
            print('caiu')
        print()
    except EOFError:
        break
