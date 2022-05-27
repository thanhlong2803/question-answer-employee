import axiosClient from "../api/axios-client";
import fetchClient from "../api/fetch-client"

import config from 'config';
const baseUrl = `${config.apiUrl}`;
const url = "/User";

export const userService = {
  getAll,
  getById,
  create,
  update
};

function getAll(parmas) {
  return axiosClient.get(url, [parmas]);
}

function getById(id) {
  return axiosClient.get(`${url}/${id}`);
}

function create(parmas) {
  return fetchClient.post(`${baseUrl}/User`, parmas);
}

function update(parmas) {
  return fetchClient.put(`${baseUrl}/User`, parmas);
}
