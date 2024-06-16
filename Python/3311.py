n = int(input())
nomes = []  

for i in range(n):
    nomes.append(input())

listao_onde_estara_os_nomes_a_serem_imprimidos_na_tela_para_resolver_o_problema_do_antigo_uri_hoje_chamado_beecrowd_porem_precisa_dar_certo_para_que_o_problema_seja_considerado_aceito_ok_ponto_ = sorted(nomes, key=lambda nome: (nome[0], nomes.index(nome)))

for nome in listao_onde_estara_os_nomes_a_serem_imprimidos_na_tela_para_resolver_o_problema_do_antigo_uri_hoje_chamado_beecrowd_porem_precisa_dar_certo_para_que_o_problema_seja_considerado_aceito_ok_ponto_:
    print(nome)

