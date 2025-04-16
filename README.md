## Documentação 1


### Arquivos úteis

* Dockerfile
* deployment.yaml

## Comandos úteis

| Comando | Descrição | Software | 
|-------|--------| -------- |
| docker build| cria a imagem da aplicação| Docker|
| docker run | cria um container com base na imagem| Docker | 
| kubectl apply -f | Executa o arquivo do kubernets| Kubernets|
|kubectl get pods| Lista todos os pods| Kubernets |
|kubectl verson|obtém a versão do kubernets| Kubernets|
|kubectl get nodes| Lista todos os nodes| Kubernets |
|kubectl delete pods --all | deleta todos os pods| Kubernets |
| kubectl delete pod meu-projeto-api-deployment-abc123 |Deleta os pods específicos | Kubernets |
| kubectl describe pod <nome-do-pod> | Usado para ver detalhes do Pod| Kubernets|
|kubectl logs <nome-do-pod> | Usado para ver os logs do Pod| Kubernets |
| kubectl scale deployment personapi-deployment --replicas=3| Usado para escalar o número de réplicas| Kubernets|
|kubectl get service -o wide| Usado para obter a porta do software | Kubernets |
|kubectl delete pods --all | Deleta todos os Pods | Kubernets|
|kubectl delete services --all| Deletea todos os services| Kubernets |
|kubectl delete deployments --all| Deleta todos os deployments|


<br>

`docker build -t meu-projeto-api .` ⮕ Cria uma imagem com base no meu projeto

`docker run --rm -p 80:80 meu-projeto-api` ⮕ Cria um container ( uma instância de minha imagem )

`docker ps` ⮕ Verifica o status de todos os containers


`docker logs <container_id> ` ⮕ Verifica os logs do container


`docker run --rm -p 8080:80 -e ASPNETCORE_URLS=http://+:80 meu-projeto-api
` ⮕ Eu posso usar linha de comando para informar em qual porta a minha aplicação do docker interna estará escutando, no meu caso, eu posso definir dentro do Dockerfile, como feito no exemplo da API pessoa
