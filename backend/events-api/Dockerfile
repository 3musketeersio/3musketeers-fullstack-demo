  
FROM node:12

WORKDIR /usr/src/app

COPY package.json ./
COPY src ./

RUN yarn

EXPOSE 8000
CMD [ "yarn", "start" ]
