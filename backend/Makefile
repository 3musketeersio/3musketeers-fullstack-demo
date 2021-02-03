

.env:
	@echo "no .env file found, copying from .env.template"
	cp .env.template .env

build: .env
	docker-compose build

start: .env
	docker-compose up

stop: .env
	docker-compose down