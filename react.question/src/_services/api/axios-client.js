import axios from "axios";
import queryString from "query-string";
import config from 'config';
  
const baseUrl = `${config.apiUrl}`; //Setting config url api 

const axiosClient = axios.create({
  baseURL: baseUrl ,
  headers: { "content-type": "appliction/json" },  
  paramsSerializers: (parmas) => queryString.stringify(parmas) 
});

//We are handel submit login send request to indentity after it authentication response token and API HTTP

axiosClient.interceptors.request.use(async (config) => {
  //add auth header with jwt if account is logged in and request is to the api url
  return config;
});

axiosClient.interceptors.response.use(
  (response) => {
    if (response && response.data) {
      return response.data;
    }
    return response;
  },
  (error) => {
    //handle error
    console.log(error);
  }
);

export default axiosClient;
