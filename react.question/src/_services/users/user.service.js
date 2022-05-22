import axiosClient from "../api/axios-client";

export const userService = {
  getAll,
};

function getAll(parmas) {
  let url = "/User";
  return axiosClient.get(url, [parmas]);
}
