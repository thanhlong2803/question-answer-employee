import axios from "axios";
import queryString from "query-string";
import config from 'config';

const baseUrl = `${config.apiUrl}`;

const axiosClient = axios.create({
  baseURL: baseUrl ,
  headers: { "content-type": "appliction/json" },
  paramsSerializers: (parmas) => queryString.stringify(parmas),
});

axiosClient.interceptors.request.use(async (config) => {
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
