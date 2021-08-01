FROM node:14

# Create app directory
WORKDIR /usr/src/app

# copy the package files containing dependencies
COPY package*.json ./

# restore dependencies
RUN npm install

# copy the applicaton bundler to container
COPY . .

# expose the running port
EXPOSE 3001

# start express server
CMD ["npm", "start"]