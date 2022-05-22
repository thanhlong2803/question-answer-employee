import axios from "axios";
import queryString from "query-string";

const axiosClient = axios.create({
  baseURL: 'https://localhost:7017/',//process.env.REACT_APP_API_URL,
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
