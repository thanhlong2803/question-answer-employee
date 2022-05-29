import axiosClient from "../api/axios-client";
import { BehaviorSubject } from "rxjs";
import axios from "axios";
const url = "https://localhost:7017/User/Authentication";

const currentUserSubject = new BehaviorSubject(
  localStorage.getItem("currentUser")
);

export const authenticationService = {
  login,
  logout,
  currentUser: currentUserSubject.asObservable(),
  get currentUserValue() {
    return currentUserSubject.value;
  },
};

function login(data) {
  const authentication = { Username: data.username, Password: data.password };
  return axios.post(url, authentication).then((res) => {
    if (res.data) {
      localStorage.setItem("currentUser", JSON.stringify(res.data));
      currentUserSubject.next(res);
    }
  });
}

function logout() {
  // remove user from local storage to log user out
  localStorage.removeItem("currentUser");
  currentUserSubject.next(null);
}

function rememberMe() {
  localStorage.setItem("Remmember", JSON.stringify(null));
}
