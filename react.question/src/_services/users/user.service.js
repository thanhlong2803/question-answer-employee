import axiosClient from "../api/axios-client";

const url = "/User";

export const userService = {
  getAll,
  getById,
};

function getAll(parmas) {
  return axiosClient.get(url, [parmas]);
}

function getById(id) {
  return axiosClient.get(`${url}/${id}`);
}

