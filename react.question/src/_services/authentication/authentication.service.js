import axiosClient from "../api/axios-client";
import { BehaviorSubject } from "rxjs";
const currentUserSubject = new BehaviorSubject(
  JSON.parse(localStorage.getItem("currentUser"))
);

export const authenticationService = {
  login,
  logout,
  currentUser: currentUserSubject.asObservable(),
  get currentUserValue() {
    return currentUserSubject.value;
  },
};

function login(username, password) {
  axiosClient.post();

  localStorage.setItem("currentUser", JSON.stringify(null));
  currentUserSubject.next(null);
  return null;
}

function logout() {
  // remove user from local storage to log user out
  localStorage.removeItem("currentUser");
  currentUserSubject.next(null);
}

function rememberMe() {
  localStorage.setItem("Remmember", JSON.stringify(null));
}
