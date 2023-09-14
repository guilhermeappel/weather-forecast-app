import axios, { AxiosInstance } from 'axios';

const BASE_URL = process.env.REACT_APP_BACKEND_URL;

const instance: AxiosInstance = axios.create({
  baseURL: BASE_URL,
  timeout: 60000,
  headers: {
    'Content-Type': 'application/json',
  },
});

// Here you can add interceptors if needed
instance.interceptors.response.use(
  (response) => response,
  (error) => {
    console.error('Axios Error:', error);
    return Promise.reject(error);
  },
);

export default instance;
