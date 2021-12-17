Rodar o comando abaixo dentro da pasta src/

podman build -f Framework.Challenge.Api/Dockerfile -t framework.challenge .       

podman run -d -p 5000:5000 --name framework.challenge localhost/framework.challenge:latest  