import axiosClient from "../api/axios-client";

const baseUrl = "/User";

export const userService = {
  getAll,
  getById,
};

function getAll(parmas) {
  return axiosClient.get(baseUrl, [parmas]);
}

function getById(id) {
  return axiosClient.get(`${baseUrl}/${id}`);
}
